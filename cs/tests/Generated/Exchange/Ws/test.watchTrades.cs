using ccxt;
using ccxt.pro;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class testMainClass : BaseTest
{
    async static public Task testWatchTrades(Exchange exchange, object skippedProperties, object symbol)
    {
        object method = "watchTrades";
        object now = exchange.milliseconds();
        object ends = add(now, 15000);
        while (isLessThan(now, ends))
        {
            object response = null;
            try
            {
                response = await exchange.watchTrades(symbol);
            } catch(Exception e)
            {
                if (!isTrue(testSharedMethods.isTemporaryFailure(e)))
                {
                    throw e;
                }
                now = exchange.milliseconds();
                continue;
            }
            testSharedMethods.assertNonEmtpyArray(exchange, skippedProperties, method, response);
            now = exchange.milliseconds();
            for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
            {
                testTrade(exchange, skippedProperties, method, getValue(response, i), symbol, now);
            }
            if (!isTrue((inOp(skippedProperties, "timestamp"))))
            {
                testSharedMethods.assertTimestampOrder(exchange, method, symbol, response);
            }
        }
    }

}