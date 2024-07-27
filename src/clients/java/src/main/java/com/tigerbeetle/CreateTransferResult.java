//////////////////////////////////////////////////////////
// This file was auto-generated by java_bindings.zig
// Do not manually modify.
//////////////////////////////////////////////////////////

package com.tigerbeetle;

public enum CreateTransferResult {

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#ok">ok</a>
     */
    Ok((int) 0),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#linked_event_failed">linked_event_failed</a>
     */
    LinkedEventFailed((int) 1),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#linked_event_chain_open">linked_event_chain_open</a>
     */
    LinkedEventChainOpen((int) 2),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#imported_event_expected">imported_event_expected</a>
     */
    ImportedEventExpected((int) 56),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#imported_event_not_expected">imported_event_not_expected</a>
     */
    ImportedEventNotExpected((int) 57),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#imported_event_must_be_linked">imported_event_must_be_linked</a>
     */
    ImportedEventMustBeLinked((int) 58),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#timestamp_must_be_zero">timestamp_must_be_zero</a>
     */
    TimestampMustBeZero((int) 3),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#imported_event_timestamp_must_not_be_zero">imported_event_timestamp_must_not_be_zero</a>
     */
    ImportedEventTimestampMustNotBeZero((int) 59),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#imported_event_timestamp_must_not_advance">imported_event_timestamp_must_not_advance</a>
     */
    ImportedEventTimestampMustNotAdvance((int) 60),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#reserved_flag">reserved_flag</a>
     */
    ReservedFlag((int) 4),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#id_must_not_be_zero">id_must_not_be_zero</a>
     */
    IdMustNotBeZero((int) 5),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#id_must_not_be_int_max">id_must_not_be_int_max</a>
     */
    IdMustNotBeIntMax((int) 6),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#flags_are_mutually_exclusive">flags_are_mutually_exclusive</a>
     */
    FlagsAreMutuallyExclusive((int) 7),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#debit_account_id_must_not_be_zero">debit_account_id_must_not_be_zero</a>
     */
    DebitAccountIdMustNotBeZero((int) 8),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#debit_account_id_must_not_be_int_max">debit_account_id_must_not_be_int_max</a>
     */
    DebitAccountIdMustNotBeIntMax((int) 9),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#credit_account_id_must_not_be_zero">credit_account_id_must_not_be_zero</a>
     */
    CreditAccountIdMustNotBeZero((int) 10),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#credit_account_id_must_not_be_int_max">credit_account_id_must_not_be_int_max</a>
     */
    CreditAccountIdMustNotBeIntMax((int) 11),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#accounts_must_be_different">accounts_must_be_different</a>
     */
    AccountsMustBeDifferent((int) 12),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_id_must_be_zero">pending_id_must_be_zero</a>
     */
    PendingIdMustBeZero((int) 13),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_id_must_not_be_zero">pending_id_must_not_be_zero</a>
     */
    PendingIdMustNotBeZero((int) 14),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_id_must_not_be_int_max">pending_id_must_not_be_int_max</a>
     */
    PendingIdMustNotBeIntMax((int) 15),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_id_must_be_different">pending_id_must_be_different</a>
     */
    PendingIdMustBeDifferent((int) 16),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#timeout_reserved_for_pending_transfer">timeout_reserved_for_pending_transfer</a>
     */
    TimeoutReservedForPendingTransfer((int) 17),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#amount_must_not_be_zero">amount_must_not_be_zero</a>
     */
    AmountMustNotBeZero((int) 18),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#ledger_must_not_be_zero">ledger_must_not_be_zero</a>
     */
    LedgerMustNotBeZero((int) 19),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#code_must_not_be_zero">code_must_not_be_zero</a>
     */
    CodeMustNotBeZero((int) 20),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#debit_account_not_found">debit_account_not_found</a>
     */
    DebitAccountNotFound((int) 21),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#credit_account_not_found">credit_account_not_found</a>
     */
    CreditAccountNotFound((int) 22),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#imported_event_debit_account_must_not_advance">imported_event_debit_account_must_not_advance</a>
     */
    ImportedEventDebitAccountMustNotAdvance((int) 61),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#imported_event_credit_account_must_not_advance">imported_event_credit_account_must_not_advance</a>
     */
    ImportedEventCreditAccountMustNotAdvance((int) 62),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#accounts_must_have_the_same_ledger">accounts_must_have_the_same_ledger</a>
     */
    AccountsMustHaveTheSameLedger((int) 23),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#transfer_must_have_the_same_ledger_as_accounts">transfer_must_have_the_same_ledger_as_accounts</a>
     */
    TransferMustHaveTheSameLedgerAsAccounts((int) 24),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_not_found">pending_transfer_not_found</a>
     */
    PendingTransferNotFound((int) 25),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_not_pending">pending_transfer_not_pending</a>
     */
    PendingTransferNotPending((int) 26),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_has_different_debit_account_id">pending_transfer_has_different_debit_account_id</a>
     */
    PendingTransferHasDifferentDebitAccountId((int) 27),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_has_different_credit_account_id">pending_transfer_has_different_credit_account_id</a>
     */
    PendingTransferHasDifferentCreditAccountId((int) 28),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_has_different_ledger">pending_transfer_has_different_ledger</a>
     */
    PendingTransferHasDifferentLedger((int) 29),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_has_different_code">pending_transfer_has_different_code</a>
     */
    PendingTransferHasDifferentCode((int) 30),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exceeds_pending_transfer_amount">exceeds_pending_transfer_amount</a>
     */
    ExceedsPendingTransferAmount((int) 31),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_has_different_amount">pending_transfer_has_different_amount</a>
     */
    PendingTransferHasDifferentAmount((int) 32),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_already_posted">pending_transfer_already_posted</a>
     */
    PendingTransferAlreadyPosted((int) 33),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_already_voided">pending_transfer_already_voided</a>
     */
    PendingTransferAlreadyVoided((int) 34),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#pending_transfer_expired">pending_transfer_expired</a>
     */
    PendingTransferExpired((int) 35),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_flags">exists_with_different_flags</a>
     */
    ExistsWithDifferentFlags((int) 36),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_debit_account_id">exists_with_different_debit_account_id</a>
     */
    ExistsWithDifferentDebitAccountId((int) 37),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_credit_account_id">exists_with_different_credit_account_id</a>
     */
    ExistsWithDifferentCreditAccountId((int) 38),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_amount">exists_with_different_amount</a>
     */
    ExistsWithDifferentAmount((int) 39),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_pending_id">exists_with_different_pending_id</a>
     */
    ExistsWithDifferentPendingId((int) 40),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_user_data_128">exists_with_different_user_data_128</a>
     */
    ExistsWithDifferentUserData128((int) 41),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_user_data_64">exists_with_different_user_data_64</a>
     */
    ExistsWithDifferentUserData64((int) 42),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_user_data_32">exists_with_different_user_data_32</a>
     */
    ExistsWithDifferentUserData32((int) 43),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_timeout">exists_with_different_timeout</a>
     */
    ExistsWithDifferentTimeout((int) 44),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists_with_different_code">exists_with_different_code</a>
     */
    ExistsWithDifferentCode((int) 45),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exists">exists</a>
     */
    Exists((int) 46),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#imported_event_timestamp_must_not_regress">imported_event_timestamp_must_not_regress</a>
     */
    ImportedEventTimestampMustNotRegress((int) 63),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#imported_event_timeout_must_be_zero">imported_event_timeout_must_be_zero</a>
     */
    ImportedEventTimeoutMustBeZero((int) 64),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#overflows_debits_pending">overflows_debits_pending</a>
     */
    OverflowsDebitsPending((int) 47),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#overflows_credits_pending">overflows_credits_pending</a>
     */
    OverflowsCreditsPending((int) 48),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#overflows_debits_posted">overflows_debits_posted</a>
     */
    OverflowsDebitsPosted((int) 49),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#overflows_credits_posted">overflows_credits_posted</a>
     */
    OverflowsCreditsPosted((int) 50),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#overflows_debits">overflows_debits</a>
     */
    OverflowsDebits((int) 51),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#overflows_credits">overflows_credits</a>
     */
    OverflowsCredits((int) 52),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#overflows_timeout">overflows_timeout</a>
     */
    OverflowsTimeout((int) 53),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exceeds_credits">exceeds_credits</a>
     */
    ExceedsCredits((int) 54),

    /**
     * @see <a href="https://docs.tigerbeetle.com/reference/requests/create_transfers#exceeds_debits">exceeds_debits</a>
     */
    ExceedsDebits((int) 55);

    public final int value;

    CreateTransferResult(int value) {
        this.value = value;
    }

    public static CreateTransferResult fromValue(int value) {
        var values = CreateTransferResult.values();
        if (value < 0 || value >= values.length)
            throw new IllegalArgumentException(
                    String.format("Invalid CreateTransferResult value=%d", value));

        return values[value];
    }
}

