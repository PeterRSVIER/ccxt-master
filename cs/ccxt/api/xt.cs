// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class xt : Exchange
{
    public xt (object args = null): base(args) {}

    public async Task<object> publicSpotGetCurrencies (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetCurrencies",parameters);
    }

    public async Task<object> publicSpotGetDepth (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetDepth",parameters);
    }

    public async Task<object> publicSpotGetKline (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetKline",parameters);
    }

    public async Task<object> publicSpotGetSymbol (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetSymbol",parameters);
    }

    public async Task<object> publicSpotGetTicker (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetTicker",parameters);
    }

    public async Task<object> publicSpotGetTickerBook (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetTickerBook",parameters);
    }

    public async Task<object> publicSpotGetTickerPrice (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetTickerPrice",parameters);
    }

    public async Task<object> publicSpotGetTicker24h (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetTicker24h",parameters);
    }

    public async Task<object> publicSpotGetTime (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetTime",parameters);
    }

    public async Task<object> publicSpotGetTradeHistory (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetTradeHistory",parameters);
    }

    public async Task<object> publicSpotGetTradeRecent (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetTradeRecent",parameters);
    }

    public async Task<object> publicSpotGetWalletSupportCurrency (object parameters = null)
    {
        return await this.callAsync ("publicSpotGetWalletSupportCurrency",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicContractRiskBalance (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicContractRiskBalance",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicContractOpenInterest (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicContractOpenInterest",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicLeverageBracketDetail (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicLeverageBracketDetail",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicLeverageBracketList (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicLeverageBracketList",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQAggTicker (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQAggTicker",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQAggTickers (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQAggTickers",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQDeal (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQDeal",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQDepth (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQDepth",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQFundingRate (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQFundingRate",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQFundingRateRecord (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQFundingRateRecord",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQIndexPrice (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQIndexPrice",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQKline (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQKline",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQMarkPrice (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQMarkPrice",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQSymbolIndexPrice (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQSymbolIndexPrice",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQSymbolMarkPrice (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQSymbolMarkPrice",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQTicker (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQTicker",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicQTickers (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicQTickers",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicSymbolCoins (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicSymbolCoins",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicSymbolDetail (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicSymbolDetail",parameters);
    }

    public async Task<object> publicLinearGetFutureMarketV1PublicSymbolList (object parameters = null)
    {
        return await this.callAsync ("publicLinearGetFutureMarketV1PublicSymbolList",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicContractRiskBalance (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicContractRiskBalance",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicContractOpenInterest (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicContractOpenInterest",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicLeverageBracketDetail (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicLeverageBracketDetail",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicLeverageBracketList (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicLeverageBracketList",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQAggTicker (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQAggTicker",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQAggTickers (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQAggTickers",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQDeal (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQDeal",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQDepth (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQDepth",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQFundingRate (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQFundingRate",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQFundingRateRecord (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQFundingRateRecord",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQIndexPrice (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQIndexPrice",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQKline (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQKline",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQMarkPrice (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQMarkPrice",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQSymbolIndexPrice (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQSymbolIndexPrice",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQSymbolMarkPrice (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQSymbolMarkPrice",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQTicker (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQTicker",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicQTickers (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicQTickers",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicSymbolCoins (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicSymbolCoins",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicSymbolDetail (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicSymbolDetail",parameters);
    }

    public async Task<object> publicInverseGetFutureMarketV1PublicSymbolList (object parameters = null)
    {
        return await this.callAsync ("publicInverseGetFutureMarketV1PublicSymbolList",parameters);
    }

    public async Task<object> privateSpotGetBalance (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetBalance",parameters);
    }

    public async Task<object> privateSpotGetBalances (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetBalances",parameters);
    }

    public async Task<object> privateSpotGetBatchOrder (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetBatchOrder",parameters);
    }

    public async Task<object> privateSpotGetDepositAddress (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetDepositAddress",parameters);
    }

    public async Task<object> privateSpotGetDepositHistory (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetDepositHistory",parameters);
    }

    public async Task<object> privateSpotGetHistoryOrder (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetHistoryOrder",parameters);
    }

    public async Task<object> privateSpotGetOpenOrder (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetOpenOrder",parameters);
    }

    public async Task<object> privateSpotGetOrder (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetOrder",parameters);
    }

    public async Task<object> privateSpotGetOrderOrderId (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetOrderOrderId",parameters);
    }

    public async Task<object> privateSpotGetTrade (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetTrade",parameters);
    }

    public async Task<object> privateSpotGetWithdrawHistory (object parameters = null)
    {
        return await this.callAsync ("privateSpotGetWithdrawHistory",parameters);
    }

    public async Task<object> privateSpotPostOrder (object parameters = null)
    {
        return await this.callAsync ("privateSpotPostOrder",parameters);
    }

    public async Task<object> privateSpotPostWithdraw (object parameters = null)
    {
        return await this.callAsync ("privateSpotPostWithdraw",parameters);
    }

    public async Task<object> privateSpotPostBalanceTransfer (object parameters = null)
    {
        return await this.callAsync ("privateSpotPostBalanceTransfer",parameters);
    }

    public async Task<object> privateSpotPostBalanceAccountTransfer (object parameters = null)
    {
        return await this.callAsync ("privateSpotPostBalanceAccountTransfer",parameters);
    }

    public async Task<object> privateSpotPostWsToken (object parameters = null)
    {
        return await this.callAsync ("privateSpotPostWsToken",parameters);
    }

    public async Task<object> privateSpotDeleteBatchOrder (object parameters = null)
    {
        return await this.callAsync ("privateSpotDeleteBatchOrder",parameters);
    }

    public async Task<object> privateSpotDeleteOpenOrder (object parameters = null)
    {
        return await this.callAsync ("privateSpotDeleteOpenOrder",parameters);
    }

    public async Task<object> privateSpotDeleteOrderOrderId (object parameters = null)
    {
        return await this.callAsync ("privateSpotDeleteOrderOrderId",parameters);
    }

    public async Task<object> privateLinearGetFutureTradeV1EntrustPlanDetail (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureTradeV1EntrustPlanDetail",parameters);
    }

    public async Task<object> privateLinearGetFutureTradeV1EntrustPlanList (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureTradeV1EntrustPlanList",parameters);
    }

    public async Task<object> privateLinearGetFutureTradeV1EntrustPlanListHistory (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureTradeV1EntrustPlanListHistory",parameters);
    }

    public async Task<object> privateLinearGetFutureTradeV1EntrustProfitDetail (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureTradeV1EntrustProfitDetail",parameters);
    }

    public async Task<object> privateLinearGetFutureTradeV1EntrustProfitList (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureTradeV1EntrustProfitList",parameters);
    }

    public async Task<object> privateLinearGetFutureTradeV1OrderDetail (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureTradeV1OrderDetail",parameters);
    }

    public async Task<object> privateLinearGetFutureTradeV1OrderList (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureTradeV1OrderList",parameters);
    }

    public async Task<object> privateLinearGetFutureTradeV1OrderListHistory (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureTradeV1OrderListHistory",parameters);
    }

    public async Task<object> privateLinearGetFutureTradeV1OrderTradeList (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureTradeV1OrderTradeList",parameters);
    }

    public async Task<object> privateLinearGetFutureUserV1AccountInfo (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureUserV1AccountInfo",parameters);
    }

    public async Task<object> privateLinearGetFutureUserV1BalanceBills (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureUserV1BalanceBills",parameters);
    }

    public async Task<object> privateLinearGetFutureUserV1BalanceDetail (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureUserV1BalanceDetail",parameters);
    }

    public async Task<object> privateLinearGetFutureUserV1BalanceFundingRateList (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureUserV1BalanceFundingRateList",parameters);
    }

    public async Task<object> privateLinearGetFutureUserV1BalanceList (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureUserV1BalanceList",parameters);
    }

    public async Task<object> privateLinearGetFutureUserV1PositionAdl (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureUserV1PositionAdl",parameters);
    }

    public async Task<object> privateLinearGetFutureUserV1PositionList (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureUserV1PositionList",parameters);
    }

    public async Task<object> privateLinearGetFutureUserV1UserCollectionList (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureUserV1UserCollectionList",parameters);
    }

    public async Task<object> privateLinearGetFutureUserV1UserListenKey (object parameters = null)
    {
        return await this.callAsync ("privateLinearGetFutureUserV1UserListenKey",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1EntrustCancelAllPlan (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1EntrustCancelAllPlan",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1EntrustCancelAllProfitStop (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1EntrustCancelAllProfitStop",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1EntrustCancelPlan (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1EntrustCancelPlan",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1EntrustCancelProfitStop (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1EntrustCancelProfitStop",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1EntrustCreatePlan (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1EntrustCreatePlan",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1EntrustCreateProfit (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1EntrustCreateProfit",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1EntrustUpdateProfitStop (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1EntrustUpdateProfitStop",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1OrderCancel (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1OrderCancel",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1OrderCancelAll (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1OrderCancelAll",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1OrderCreate (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1OrderCreate",parameters);
    }

    public async Task<object> privateLinearPostFutureTradeV1OrderCreateBatch (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureTradeV1OrderCreateBatch",parameters);
    }

    public async Task<object> privateLinearPostFutureUserV1AccountOpen (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureUserV1AccountOpen",parameters);
    }

    public async Task<object> privateLinearPostFutureUserV1PositionAdjustLeverage (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureUserV1PositionAdjustLeverage",parameters);
    }

    public async Task<object> privateLinearPostFutureUserV1PositionAutoMargin (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureUserV1PositionAutoMargin",parameters);
    }

    public async Task<object> privateLinearPostFutureUserV1PositionCloseAll (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureUserV1PositionCloseAll",parameters);
    }

    public async Task<object> privateLinearPostFutureUserV1PositionMargin (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureUserV1PositionMargin",parameters);
    }

    public async Task<object> privateLinearPostFutureUserV1UserCollectionAdd (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureUserV1UserCollectionAdd",parameters);
    }

    public async Task<object> privateLinearPostFutureUserV1UserCollectionCancel (object parameters = null)
    {
        return await this.callAsync ("privateLinearPostFutureUserV1UserCollectionCancel",parameters);
    }

    public async Task<object> privateInverseGetFutureTradeV1EntrustPlanDetail (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureTradeV1EntrustPlanDetail",parameters);
    }

    public async Task<object> privateInverseGetFutureTradeV1EntrustPlanList (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureTradeV1EntrustPlanList",parameters);
    }

    public async Task<object> privateInverseGetFutureTradeV1EntrustPlanListHistory (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureTradeV1EntrustPlanListHistory",parameters);
    }

    public async Task<object> privateInverseGetFutureTradeV1EntrustProfitDetail (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureTradeV1EntrustProfitDetail",parameters);
    }

    public async Task<object> privateInverseGetFutureTradeV1EntrustProfitList (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureTradeV1EntrustProfitList",parameters);
    }

    public async Task<object> privateInverseGetFutureTradeV1OrderDetail (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureTradeV1OrderDetail",parameters);
    }

    public async Task<object> privateInverseGetFutureTradeV1OrderList (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureTradeV1OrderList",parameters);
    }

    public async Task<object> privateInverseGetFutureTradeV1OrderListHistory (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureTradeV1OrderListHistory",parameters);
    }

    public async Task<object> privateInverseGetFutureTradeV1OrderTradeList (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureTradeV1OrderTradeList",parameters);
    }

    public async Task<object> privateInverseGetFutureUserV1AccountInfo (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureUserV1AccountInfo",parameters);
    }

    public async Task<object> privateInverseGetFutureUserV1BalanceBills (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureUserV1BalanceBills",parameters);
    }

    public async Task<object> privateInverseGetFutureUserV1BalanceDetail (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureUserV1BalanceDetail",parameters);
    }

    public async Task<object> privateInverseGetFutureUserV1BalanceFundingRateList (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureUserV1BalanceFundingRateList",parameters);
    }

    public async Task<object> privateInverseGetFutureUserV1BalanceList (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureUserV1BalanceList",parameters);
    }

    public async Task<object> privateInverseGetFutureUserV1PositionAdl (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureUserV1PositionAdl",parameters);
    }

    public async Task<object> privateInverseGetFutureUserV1PositionList (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureUserV1PositionList",parameters);
    }

    public async Task<object> privateInverseGetFutureUserV1UserCollectionList (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureUserV1UserCollectionList",parameters);
    }

    public async Task<object> privateInverseGetFutureUserV1UserListenKey (object parameters = null)
    {
        return await this.callAsync ("privateInverseGetFutureUserV1UserListenKey",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1EntrustCancelAllPlan (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1EntrustCancelAllPlan",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1EntrustCancelAllProfitStop (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1EntrustCancelAllProfitStop",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1EntrustCancelPlan (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1EntrustCancelPlan",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1EntrustCancelProfitStop (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1EntrustCancelProfitStop",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1EntrustCreatePlan (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1EntrustCreatePlan",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1EntrustCreateProfit (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1EntrustCreateProfit",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1EntrustUpdateProfitStop (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1EntrustUpdateProfitStop",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1OrderCancel (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1OrderCancel",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1OrderCancelAll (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1OrderCancelAll",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1OrderCreate (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1OrderCreate",parameters);
    }

    public async Task<object> privateInversePostFutureTradeV1OrderCreateBatch (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureTradeV1OrderCreateBatch",parameters);
    }

    public async Task<object> privateInversePostFutureUserV1AccountOpen (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureUserV1AccountOpen",parameters);
    }

    public async Task<object> privateInversePostFutureUserV1PositionAdjustLeverage (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureUserV1PositionAdjustLeverage",parameters);
    }

    public async Task<object> privateInversePostFutureUserV1PositionAutoMargin (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureUserV1PositionAutoMargin",parameters);
    }

    public async Task<object> privateInversePostFutureUserV1PositionCloseAll (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureUserV1PositionCloseAll",parameters);
    }

    public async Task<object> privateInversePostFutureUserV1PositionMargin (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureUserV1PositionMargin",parameters);
    }

    public async Task<object> privateInversePostFutureUserV1UserCollectionAdd (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureUserV1UserCollectionAdd",parameters);
    }

    public async Task<object> privateInversePostFutureUserV1UserCollectionCancel (object parameters = null)
    {
        return await this.callAsync ("privateInversePostFutureUserV1UserCollectionCancel",parameters);
    }

    public async Task<object> privateUserGetUserAccount (object parameters = null)
    {
        return await this.callAsync ("privateUserGetUserAccount",parameters);
    }

    public async Task<object> privateUserGetUserAccountApiKey (object parameters = null)
    {
        return await this.callAsync ("privateUserGetUserAccountApiKey",parameters);
    }

    public async Task<object> privateUserPostUserAccount (object parameters = null)
    {
        return await this.callAsync ("privateUserPostUserAccount",parameters);
    }

    public async Task<object> privateUserPostUserAccountApiKey (object parameters = null)
    {
        return await this.callAsync ("privateUserPostUserAccountApiKey",parameters);
    }

    public async Task<object> privateUserPutUserAccountApiKey (object parameters = null)
    {
        return await this.callAsync ("privateUserPutUserAccountApiKey",parameters);
    }

    public async Task<object> privateUserDeleteUserAccountApikeyId (object parameters = null)
    {
        return await this.callAsync ("privateUserDeleteUserAccountApikeyId",parameters);
    }

}