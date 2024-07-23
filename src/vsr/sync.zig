const std = @import("std");
const assert = std.debug.assert;
const maybe = stdx.maybe;

const vsr = @import("../vsr.zig");
const constants = @import("../constants.zig");
const stdx = @import("../stdx.zig");

pub const Stage = union(enum) {
    idle,

    /// The commit lifecycle is in a stage that cannot be interrupted/canceled.
    /// We are waiting until that uninterruptible stage completes.
    /// When it completes, we will abort the commit chain and resume sync.
    /// (State sync will replace any changes the commit made anyway.)
    canceling_commit,

    /// Waiting for `Grid.cancel()`.
    canceling_grid,

    /// We need to sync, but are waiting for a usable `sync_target_max`.
    awaiting_checkpoint,

    updating_superblock: UpdatingSuperBlock,

    pub const UpdatingSuperBlock = struct {
        // target: Target,
        checkpoint_state: vsr.CheckpointState,
    };

    pub fn valid_transition(from: std.meta.Tag(Stage), to: std.meta.Tag(Stage)) bool {
        return switch (from) {
            .idle => to == .canceling_commit or
                to == .canceling_grid or
                to == .awaiting_checkpoint,
            .canceling_commit => to == .canceling_grid,
            .canceling_grid => to == .awaiting_checkpoint,
            .awaiting_checkpoint => to == .awaiting_checkpoint or to == .updating_superblock,
            .updating_superblock => to == .idle,
        };
    }
};
