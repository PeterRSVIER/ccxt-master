<?php
namespace ccxt;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
use React\Async;
use React\Promise;
include_once PATH_TO_CCXT . '/test/exchange/base/test_leverage_tier.php';
include_once PATH_TO_CCXT . '/test/exchange/base/test_shared_methods.php';

function test_fetch_market_leverage_tiers($exchange, $skipped_properties, $symbol) {
    return Async\async(function () use ($exchange, $skipped_properties, $symbol) {
        $method = 'fetchMarketLeverageTiers';
        $tiers = Async\await($exchange->fetch_market_leverage_tiers($symbol));
        assert_non_emtpy_array($exchange, $skipped_properties, $method, $tiers, $symbol);
        for ($j = 0; $j < count($tiers); $j++) {
            test_leverage_tier($exchange, $skipped_properties, $method, $tiers[$j]);
        }
    }) ();
}