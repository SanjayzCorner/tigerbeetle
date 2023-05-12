//////////////////////////////////////////////////////////
// This file was auto-generated by dotnet_bindings.zig  //
//              Do not manually modify.                 //
//////////////////////////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace TigerBeetle
{
    [Flags]
    public enum AccountFlags : ushort
    {
        None = 0,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts#flagslinked
        /// </summary>
        Linked = 1 << 0,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts#flagsdebits_must_not_exceed_credits
        /// </summary>
        DebitsMustNotExceedCredits = 1 << 1,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts#flagscredits_must_not_exceed_debits
        /// </summary>
        CreditsMustNotExceedDebits = 1 << 2,

    }

    [Flags]
    public enum TransferFlags : ushort
    {
        None = 0,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers#flagslinked
        /// </summary>
        Linked = 1 << 0,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers#flagspending
        /// </summary>
        Pending = 1 << 1,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers#flagspost_pending_transfer
        /// </summary>
        PostPendingTransfer = 1 << 2,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers#flagsvoid_pending_transfer
        /// </summary>
        VoidPendingTransfer = 1 << 3,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers#flagsbalancing_debit
        /// </summary>
        BalancingDebit = 1 << 4,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers#flagsbalancing_credit
        /// </summary>
        BalancingCredit = 1 << 5,

    }

    [StructLayout(LayoutKind.Sequential, Size = SIZE)]
    public struct Account
    {
        public const int SIZE = 128;

        [StructLayout(LayoutKind.Sequential, Size = SIZE)]
        private unsafe struct ReservedData
        {
            public const int SIZE = 48;

            private fixed byte raw[SIZE];

            public byte[] GetData()
            {
                fixed (void* ptr = raw)
                {
                    return new ReadOnlySpan<byte>(ptr, SIZE).ToArray();
                }
            }

            public void SetData(byte[] value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (value.Length != SIZE) throw new ArgumentException("Expected a byte[" + SIZE + "] array", nameof(value));

                fixed (void* ptr = raw)
                {
                    value.CopyTo(new Span<byte>(ptr, SIZE));
                }
            }
        }

        private UInt128 id;

        private UInt128 userData;

        private ReservedData reserved;

        private uint ledger;

        private ushort code;

        private AccountFlags flags;

        private ulong debitsPending;

        private ulong debitsPosted;

        private ulong creditsPending;

        private ulong creditsPosted;

        private ulong timestamp;

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#id
        /// </summary>
        public UInt128 Id { get => id; set => id = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#user_data
        /// </summary>
        public UInt128 UserData { get => userData; set => userData = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#reserved
        /// </summary>
        internal byte[] Reserved { get => reserved.GetData(); set => reserved.SetData(value); }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#ledger
        /// </summary>
        public uint Ledger { get => ledger; set => ledger = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#code
        /// </summary>
        public ushort Code { get => code; set => code = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#flags
        /// </summary>
        public AccountFlags Flags { get => flags; set => flags = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#debits_pending
        /// </summary>
        public ulong DebitsPending { get => debitsPending; internal set => debitsPending = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#debits_posted
        /// </summary>
        public ulong DebitsPosted { get => debitsPosted; internal set => debitsPosted = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#credits_pending
        /// </summary>
        public ulong CreditsPending { get => creditsPending; internal set => creditsPending = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#credits_posted
        /// </summary>
        public ulong CreditsPosted { get => creditsPosted; internal set => creditsPosted = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/accounts/#timestamp
        /// </summary>
        public ulong Timestamp { get => timestamp; internal set => timestamp = value; }

    }

    [StructLayout(LayoutKind.Sequential, Size = SIZE)]
    public struct Transfer
    {
        public const int SIZE = 128;

        private UInt128 id;

        private UInt128 debitAccountId;

        private UInt128 creditAccountId;

        private UInt128 userData;

        private UInt128 reserved;

        private UInt128 pendingId;

        private ulong timeout;

        private uint ledger;

        private ushort code;

        private TransferFlags flags;

        private ulong amount;

        private ulong timestamp;

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#id
        /// </summary>
        public UInt128 Id { get => id; set => id = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#debit_account_id
        /// </summary>
        public UInt128 DebitAccountId { get => debitAccountId; set => debitAccountId = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#credit_account_id
        /// </summary>
        public UInt128 CreditAccountId { get => creditAccountId; set => creditAccountId = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#user_data
        /// </summary>
        public UInt128 UserData { get => userData; set => userData = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#reserved
        /// </summary>
        internal UInt128 Reserved { get => reserved; set => reserved = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#pending_id
        /// </summary>
        public UInt128 PendingId { get => pendingId; set => pendingId = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#timeout
        /// </summary>
        public ulong Timeout { get => timeout; set => timeout = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#ledger
        /// </summary>
        public uint Ledger { get => ledger; set => ledger = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#code
        /// </summary>
        public ushort Code { get => code; set => code = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#flags
        /// </summary>
        public TransferFlags Flags { get => flags; set => flags = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#amount
        /// </summary>
        public ulong Amount { get => amount; set => amount = value; }

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/transfers/#timestamp
        /// </summary>
        public ulong Timestamp { get => timestamp; internal set => timestamp = value; }

    }

    public enum CreateAccountResult : uint
    {
        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#ok
        /// </summary>
        Ok = 0,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#linked_event_failed
        /// </summary>
        LinkedEventFailed = 1,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#linked_event_chain_open
        /// </summary>
        LinkedEventChainOpen = 2,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#timestamp_must_be_zero
        /// </summary>
        TimestampMustBeZero = 3,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#reserved_flag
        /// </summary>
        ReservedFlag = 4,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#reserved_field
        /// </summary>
        ReservedField = 5,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#id_must_not_be_zero
        /// </summary>
        IdMustNotBeZero = 6,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#id_must_not_be_int_max
        /// </summary>
        IdMustNotBeIntMax = 7,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#flags_are_mutually_exclusive
        /// </summary>
        FlagsAreMutuallyExclusive = 8,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#ledger_must_not_be_zero
        /// </summary>
        LedgerMustNotBeZero = 9,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#code_must_not_be_zero
        /// </summary>
        CodeMustNotBeZero = 10,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#debits_pending_must_be_zero
        /// </summary>
        DebitsPendingMustBeZero = 11,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#debits_posted_must_be_zero
        /// </summary>
        DebitsPostedMustBeZero = 12,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#credits_pending_must_be_zero
        /// </summary>
        CreditsPendingMustBeZero = 13,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#credits_posted_must_be_zero
        /// </summary>
        CreditsPostedMustBeZero = 14,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#exists_with_different_flags
        /// </summary>
        ExistsWithDifferentFlags = 15,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#exists_with_different_user_data
        /// </summary>
        ExistsWithDifferentUserData = 16,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#exists_with_different_ledger
        /// </summary>
        ExistsWithDifferentLedger = 17,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#exists_with_different_code
        /// </summary>
        ExistsWithDifferentCode = 18,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_accounts#exists
        /// </summary>
        Exists = 19,

    }

    public enum CreateTransferResult : uint
    {
        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#ok
        /// </summary>
        Ok = 0,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#linked_event_failed
        /// </summary>
        LinkedEventFailed = 1,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#linked_event_chain_open
        /// </summary>
        LinkedEventChainOpen = 2,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#timestamp_must_be_zero
        /// </summary>
        TimestampMustBeZero = 3,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#reserved_flag
        /// </summary>
        ReservedFlag = 4,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#reserved_field
        /// </summary>
        ReservedField = 5,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#id_must_not_be_zero
        /// </summary>
        IdMustNotBeZero = 6,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#id_must_not_be_int_max
        /// </summary>
        IdMustNotBeIntMax = 7,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#flags_are_mutually_exclusive
        /// </summary>
        FlagsAreMutuallyExclusive = 8,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#debit_account_id_must_not_be_zero
        /// </summary>
        DebitAccountIdMustNotBeZero = 9,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#debit_account_id_must_not_be_int_max
        /// </summary>
        DebitAccountIdMustNotBeIntMax = 10,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#credit_account_id_must_not_be_zero
        /// </summary>
        CreditAccountIdMustNotBeZero = 11,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#credit_account_id_must_not_be_int_max
        /// </summary>
        CreditAccountIdMustNotBeIntMax = 12,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#accounts_must_be_different
        /// </summary>
        AccountsMustBeDifferent = 13,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_id_must_be_zero
        /// </summary>
        PendingIdMustBeZero = 14,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_id_must_not_be_zero
        /// </summary>
        PendingIdMustNotBeZero = 15,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_id_must_not_be_int_max
        /// </summary>
        PendingIdMustNotBeIntMax = 16,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_id_must_be_different
        /// </summary>
        PendingIdMustBeDifferent = 17,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#timeout_reserved_for_pending_transfer
        /// </summary>
        TimeoutReservedForPendingTransfer = 18,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#ledger_must_not_be_zero
        /// </summary>
        LedgerMustNotBeZero = 19,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#code_must_not_be_zero
        /// </summary>
        CodeMustNotBeZero = 20,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#amount_must_not_be_zero
        /// </summary>
        AmountMustNotBeZero = 21,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#debit_account_not_found
        /// </summary>
        DebitAccountNotFound = 22,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#credit_account_not_found
        /// </summary>
        CreditAccountNotFound = 23,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#accounts_must_have_the_same_ledger
        /// </summary>
        AccountsMustHaveTheSameLedger = 24,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#transfer_must_have_the_same_ledger_as_accounts
        /// </summary>
        TransferMustHaveTheSameLedgerAsAccounts = 25,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_not_found
        /// </summary>
        PendingTransferNotFound = 26,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_not_pending
        /// </summary>
        PendingTransferNotPending = 27,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_has_different_debit_account_id
        /// </summary>
        PendingTransferHasDifferentDebitAccountId = 28,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_has_different_credit_account_id
        /// </summary>
        PendingTransferHasDifferentCreditAccountId = 29,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_has_different_ledger
        /// </summary>
        PendingTransferHasDifferentLedger = 30,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_has_different_code
        /// </summary>
        PendingTransferHasDifferentCode = 31,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exceeds_pending_transfer_amount
        /// </summary>
        ExceedsPendingTransferAmount = 32,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_has_different_amount
        /// </summary>
        PendingTransferHasDifferentAmount = 33,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_already_posted
        /// </summary>
        PendingTransferAlreadyPosted = 34,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_already_voided
        /// </summary>
        PendingTransferAlreadyVoided = 35,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#pending_transfer_expired
        /// </summary>
        PendingTransferExpired = 36,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exists_with_different_flags
        /// </summary>
        ExistsWithDifferentFlags = 37,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exists_with_different_debit_account_id
        /// </summary>
        ExistsWithDifferentDebitAccountId = 38,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exists_with_different_credit_account_id
        /// </summary>
        ExistsWithDifferentCreditAccountId = 39,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exists_with_different_pending_id
        /// </summary>
        ExistsWithDifferentPendingId = 40,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exists_with_different_user_data
        /// </summary>
        ExistsWithDifferentUserData = 41,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exists_with_different_timeout
        /// </summary>
        ExistsWithDifferentTimeout = 42,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exists_with_different_code
        /// </summary>
        ExistsWithDifferentCode = 43,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exists_with_different_amount
        /// </summary>
        ExistsWithDifferentAmount = 44,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exists
        /// </summary>
        Exists = 45,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#overflows_debits_pending
        /// </summary>
        OverflowsDebitsPending = 46,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#overflows_credits_pending
        /// </summary>
        OverflowsCreditsPending = 47,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#overflows_debits_posted
        /// </summary>
        OverflowsDebitsPosted = 48,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#overflows_credits_posted
        /// </summary>
        OverflowsCreditsPosted = 49,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#overflows_debits
        /// </summary>
        OverflowsDebits = 50,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#overflows_credits
        /// </summary>
        OverflowsCredits = 51,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#overflows_timeout
        /// </summary>
        OverflowsTimeout = 52,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exceeds_credits
        /// </summary>
        ExceedsCredits = 53,

        /// <summary>
        /// https://docs.tigerbeetle.com/reference/operations/create_transfers#exceeds_debits
        /// </summary>
        ExceedsDebits = 54,

    }

    [StructLayout(LayoutKind.Sequential, Size = SIZE)]
    public struct CreateAccountsResult
    {
        public const int SIZE = 8;

        private uint index;

        private CreateAccountResult result;

        public uint Index { get => index; set => index = value; }

        public CreateAccountResult Result { get => result; set => result = value; }

    }

    [StructLayout(LayoutKind.Sequential, Size = SIZE)]
    public struct CreateTransfersResult
    {
        public const int SIZE = 8;

        private uint index;

        private CreateTransferResult result;

        public uint Index { get => index; set => index = value; }

        public CreateTransferResult Result { get => result; set => result = value; }

    }

    public enum InitializationStatus : uint
    {
        Success = 0,

        Unexpected = 1,

        OutOfMemory = 2,

        AddressInvalid = 3,

        AddressLimitExceeded = 4,

        PacketsCountInvalid = 5,

        SystemResources = 6,

        NetworkSubsystem = 7,

    }

    public enum PacketStatus : byte
    {
        Ok = 0,

        TooMuchData = 1,

        InvalidOperation = 2,

        InvalidDataSize = 3,

    }

    internal enum TBOperation : byte
    {
        CreateAccounts = 128,

        CreateTransfers = 129,

        LookupAccounts = 130,

        LookupTransfers = 131,

    }

    [StructLayout(LayoutKind.Sequential, Size = SIZE)]
    internal unsafe struct TBPacket
    {
        public const int SIZE = 32;

        public TBPacket* next;

        public IntPtr userData;

        public byte operation;

        public PacketStatus status;

        public uint dataSize;

        public IntPtr data;

    }

    internal static class TBClient
    {
        private const string LIB_NAME = "tb_client";

        // Uses either the new function pointer by value, or the old managed delegate in .Net standard
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/function-pointers

#if NETSTANDARD
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void OnCompletionFn(IntPtr ctx, IntPtr client, TBPacket* packet, byte* result, uint result_len);
#endif

        [DllImport(LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern InitializationStatus tb_client_init(
            IntPtr* out_client,
            uint cluster_id,
            byte* address_ptr,
            uint address_len,
            uint num_packets,
            IntPtr on_completion_ctx,

#if NETSTANDARD
            [MarshalAs(UnmanagedType.FunctionPtr)]
            OnCompletionFn on_completion_fn
#else
            delegate* unmanaged[Cdecl]<IntPtr, IntPtr, TBPacket*, byte*, uint, void> on_completion_fn
#endif
        );

        [DllImport(LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern InitializationStatus tb_client_init_echo(
            IntPtr* out_client,
            uint cluster_id,
            byte* address_ptr,
            uint address_len,
            uint num_packets,
            IntPtr on_completion_ctx,

#if NETSTANDARD
            [MarshalAs(UnmanagedType.FunctionPtr)]
            OnCompletionFn on_completion_fn
#else
            delegate* unmanaged[Cdecl]<IntPtr, IntPtr, TBPacket*, byte*, uint, void> on_completion_fn
#endif
        );

        [DllImport(LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern TBPacket* tb_client_acquire_packet(
            IntPtr client
        );

        [DllImport(LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern void tb_client_release_packet(
            IntPtr client,
            TBPacket* packet
        );

        [DllImport(LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern void tb_client_submit(
            IntPtr client,
            TBPacket* packet
        );

        [DllImport(LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern void tb_client_deinit(
            IntPtr client
        );
    }
}

