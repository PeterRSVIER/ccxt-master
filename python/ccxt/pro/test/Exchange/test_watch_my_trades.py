import os
import sys

root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))))
sys.path.append(root)

# ----------------------------------------------------------------------------

# PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
# https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

# ----------------------------------------------------------------------------
# -*- coding: utf-8 -*-

from ccxt.test.exchange.base import test_trade  # noqa E402
from ccxt.test.exchange.base import test_shared_methods  # noqa E402

async def test_watch_my_trades(exchange, skipped_properties, symbol):
    method = 'watchMyTrades'
    now = exchange.milliseconds()
    ends = now + 15000
    while now < ends:
        response = None
        try:
            response = await exchange.watch_my_trades(symbol)
        except Exception as e:
            if not test_shared_methods.is_temporary_failure(e):
                raise e
            now = exchange.milliseconds()
            continue
        test_shared_methods.assert_non_emtpy_array(exchange, skipped_properties, method, response, symbol)
        now = exchange.milliseconds()
        for i in range(0, len(response)):
            test_trade(exchange, skipped_properties, method, response[i], symbol, now)
        test_shared_methods.assert_timestamp_order(exchange, method, symbol, response)