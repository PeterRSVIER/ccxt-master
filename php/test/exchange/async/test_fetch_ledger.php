<?php
namespace ccxt;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
use React\Async;
use React\Promise;
include_once PATH_TO_CCXT . '/test/exchange/base/test_ledger_entry.php';
include_once PATH_TO_CCXT . '/test/exchange/base/test_shared_methods.php';

function test_fetch_ledger($exchange, $skipped_properties, $code) {
    return Async\async(function () use ($exchange, $skipped_properties, $code) {
        $method = 'fetchLedger';
        $items = Async\await($exchange->fetch_ledger($code));
        assert_non_emtpy_array($exchange, $skipped_properties, $method, $items, $code);
        $now = $exchange->milliseconds();
        for ($i = 0; $i < count($items); $i++) {
            test_ledger_entry($exchange, $skipped_properties, $method, $items[$i], $code, $now);
        }
        assert_timestamp_order($exchange, $method, $code, $items);
    }) ();
}