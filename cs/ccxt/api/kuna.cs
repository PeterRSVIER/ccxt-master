// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class kuna : Exchange
{
    public kuna (object args = null): base(args) {}

    public async Task<object> xreserveGetNonce (object parameters = null)
    {
        return await this.callAsync ("xreserveGetNonce",parameters);
    }

    public async Task<object> xreserveGetFee (object parameters = null)
    {
        return await this.callAsync ("xreserveGetFee",parameters);
    }

    public async Task<object> xreserveGetDelegatedTransactions (object parameters = null)
    {
        return await this.callAsync ("xreserveGetDelegatedTransactions",parameters);
    }

    public async Task<object> xreservePostDelegateTransfer (object parameters = null)
    {
        return await this.callAsync ("xreservePostDelegateTransfer",parameters);
    }

    public async Task<object> v4PrivateGetPrivateMe (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetPrivateMe",parameters);
    }

    public async Task<object> v4PrivateGetPrivateGetBalance (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetPrivateGetBalance",parameters);
    }

    public async Task<object> v4PrivateGetOrderPrivateActive (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetOrderPrivateActive",parameters);
    }

    public async Task<object> v4PrivateGetOrderPrivateHistory (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetOrderPrivateHistory",parameters);
    }

    public async Task<object> v4PrivateGetOrderPrivateIdTrades (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetOrderPrivateIdTrades",parameters);
    }

    public async Task<object> v4PrivateGetOrderPrivateDetailsId (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetOrderPrivateDetailsId",parameters);
    }

    public async Task<object> v4PrivateGetTradePrivateHistory (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetTradePrivateHistory",parameters);
    }

    public async Task<object> v4PrivateGetTransactionPrivateHash (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetTransactionPrivateHash",parameters);
    }

    public async Task<object> v4PrivateGetDepositPrivatePreRequest (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetDepositPrivatePreRequest",parameters);
    }

    public async Task<object> v4PrivateGetDepositPrivateCryptoAddress (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetDepositPrivateCryptoAddress",parameters);
    }

    public async Task<object> v4PrivateGetDepositPrivateCryptoGetMerchantAddress (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetDepositPrivateCryptoGetMerchantAddress",parameters);
    }

    public async Task<object> v4PrivateGetDepositPrivateHistory (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetDepositPrivateHistory",parameters);
    }

    public async Task<object> v4PrivateGetDepositPrivateDetailsDepositId (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetDepositPrivateDetailsDepositId",parameters);
    }

    public async Task<object> v4PrivateGetWithdrawPrivatePreRequest (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetWithdrawPrivatePreRequest",parameters);
    }

    public async Task<object> v4PrivateGetWithdrawPrivateHistory (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetWithdrawPrivateHistory",parameters);
    }

    public async Task<object> v4PrivateGetWithdrawPrivateDetailsWithdrawId (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetWithdrawPrivateDetailsWithdrawId",parameters);
    }

    public async Task<object> v4PrivateGetKunaCodeId (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetKunaCodeId",parameters);
    }

    public async Task<object> v4PrivateGetKunaCodeCodeCheck (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetKunaCodeCodeCheck",parameters);
    }

    public async Task<object> v4PrivateGetKunaCodeIssuedByMe (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetKunaCodeIssuedByMe",parameters);
    }

    public async Task<object> v4PrivateGetKunaCodeRedeemedByMe (object parameters = null)
    {
        return await this.callAsync ("v4PrivateGetKunaCodeRedeemedByMe",parameters);
    }

    public async Task<object> v4PrivatePostOrderPrivateCreate (object parameters = null)
    {
        return await this.callAsync ("v4PrivatePostOrderPrivateCreate",parameters);
    }

    public async Task<object> v4PrivatePostOrderPrivateCancel (object parameters = null)
    {
        return await this.callAsync ("v4PrivatePostOrderPrivateCancel",parameters);
    }

    public async Task<object> v4PrivatePostOrderPrivateCancelMulti (object parameters = null)
    {
        return await this.callAsync ("v4PrivatePostOrderPrivateCancelMulti",parameters);
    }

    public async Task<object> v4PrivatePostDepositPrivateCryptoGenerateAddress (object parameters = null)
    {
        return await this.callAsync ("v4PrivatePostDepositPrivateCryptoGenerateAddress",parameters);
    }

    public async Task<object> v4PrivatePostDepositPrivateCryptoGenerateMerchantAddress (object parameters = null)
    {
        return await this.callAsync ("v4PrivatePostDepositPrivateCryptoGenerateMerchantAddress",parameters);
    }

    public async Task<object> v4PrivatePostWithdrawPrivateCreate (object parameters = null)
    {
        return await this.callAsync ("v4PrivatePostWithdrawPrivateCreate",parameters);
    }

    public async Task<object> v4PrivatePostKunaCode (object parameters = null)
    {
        return await this.callAsync ("v4PrivatePostKunaCode",parameters);
    }

    public async Task<object> v4PrivatePutKunaCodeRedeem (object parameters = null)
    {
        return await this.callAsync ("v4PrivatePutKunaCodeRedeem",parameters);
    }

    public async Task<object> v4PublicGetPublicTimestamp (object parameters = null)
    {
        return await this.callAsync ("v4PublicGetPublicTimestamp",parameters);
    }

    public async Task<object> v4PublicGetPublicFees (object parameters = null)
    {
        return await this.callAsync ("v4PublicGetPublicFees",parameters);
    }

    public async Task<object> v4PublicGetPublicCurrenciesTypeType (object parameters = null)
    {
        return await this.callAsync ("v4PublicGetPublicCurrenciesTypeType",parameters);
    }

    public async Task<object> v4PublicGetPublicCurrencies (object parameters = null)
    {
        return await this.callAsync ("v4PublicGetPublicCurrencies",parameters);
    }

    public async Task<object> v4PublicGetMarketsPublicGetAll (object parameters = null)
    {
        return await this.callAsync ("v4PublicGetMarketsPublicGetAll",parameters);
    }

    public async Task<object> v4PublicGetMarketsPublicTickersPairsPairs (object parameters = null)
    {
        return await this.callAsync ("v4PublicGetMarketsPublicTickersPairsPairs",parameters);
    }

    public async Task<object> v4PublicGetOrderPublicBookPairs (object parameters = null)
    {
        return await this.callAsync ("v4PublicGetOrderPublicBookPairs",parameters);
    }

    public async Task<object> v4PublicGetTradePublicBookPairs (object parameters = null)
    {
        return await this.callAsync ("v4PublicGetTradePublicBookPairs",parameters);
    }

    public async Task<object> v3PublicGetTimestamp (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetTimestamp",parameters);
    }

    public async Task<object> v3PublicGetCurrencies (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetCurrencies",parameters);
    }

    public async Task<object> v3PublicGetMarkets (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetMarkets",parameters);
    }

    public async Task<object> v3PublicGetTickers (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetTickers",parameters);
    }

    public async Task<object> v3PublicGetK (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetK",parameters);
    }

    public async Task<object> v3PublicGetTradesHistory (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetTradesHistory",parameters);
    }

    public async Task<object> v3PublicGetFees (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetFees",parameters);
    }

    public async Task<object> v3PublicGetExchangeRates (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetExchangeRates",parameters);
    }

    public async Task<object> v3PublicGetExchangeRatesCurrency (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetExchangeRatesCurrency",parameters);
    }

    public async Task<object> v3PublicGetBookMarket (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetBookMarket",parameters);
    }

    public async Task<object> v3PublicGetKunaCodesCodeCheck (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetKunaCodesCodeCheck",parameters);
    }

    public async Task<object> v3PublicGetLandingPageStatistic (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetLandingPageStatistic",parameters);
    }

    public async Task<object> v3PublicGetTranslationsLocale (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetTranslationsLocale",parameters);
    }

    public async Task<object> v3PublicGetTradesMarketHist (object parameters = null)
    {
        return await this.callAsync ("v3PublicGetTradesMarketHist",parameters);
    }

    public async Task<object> v3PublicPostHttpTest (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostHttpTest",parameters);
    }

    public async Task<object> v3PublicPostDepositChannels (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostDepositChannels",parameters);
    }

    public async Task<object> v3PublicPostWithdrawChannels (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostWithdrawChannels",parameters);
    }

    public async Task<object> v3PublicPostSubscriptionPlans (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostSubscriptionPlans",parameters);
    }

    public async Task<object> v3PublicPostSendTo (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostSendTo",parameters);
    }

    public async Task<object> v3PublicPostConfirmToken (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostConfirmToken",parameters);
    }

    public async Task<object> v3PublicPostKunaid (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostKunaid",parameters);
    }

    public async Task<object> v3PublicPostWithdrawPrerequest (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostWithdrawPrerequest",parameters);
    }

    public async Task<object> v3PublicPostDepositPrerequest (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostDepositPrerequest",parameters);
    }

    public async Task<object> v3PublicPostDepositExchangeRates (object parameters = null)
    {
        return await this.callAsync ("v3PublicPostDepositExchangeRates",parameters);
    }

    public async Task<object> v3SignGetResetPasswordToken (object parameters = null)
    {
        return await this.callAsync ("v3SignGetResetPasswordToken",parameters);
    }

    public async Task<object> v3SignPostSignupGoogle (object parameters = null)
    {
        return await this.callAsync ("v3SignPostSignupGoogle",parameters);
    }

    public async Task<object> v3SignPostSignupResendConfirmation (object parameters = null)
    {
        return await this.callAsync ("v3SignPostSignupResendConfirmation",parameters);
    }

    public async Task<object> v3SignPostSignup (object parameters = null)
    {
        return await this.callAsync ("v3SignPostSignup",parameters);
    }

    public async Task<object> v3SignPostSignin (object parameters = null)
    {
        return await this.callAsync ("v3SignPostSignin",parameters);
    }

    public async Task<object> v3SignPostSigninTwoFactor (object parameters = null)
    {
        return await this.callAsync ("v3SignPostSigninTwoFactor",parameters);
    }

    public async Task<object> v3SignPostSigninResendConfirmDevice (object parameters = null)
    {
        return await this.callAsync ("v3SignPostSigninResendConfirmDevice",parameters);
    }

    public async Task<object> v3SignPostSigninConfirmDevice (object parameters = null)
    {
        return await this.callAsync ("v3SignPostSigninConfirmDevice",parameters);
    }

    public async Task<object> v3SignPostResetPassword (object parameters = null)
    {
        return await this.callAsync ("v3SignPostResetPassword",parameters);
    }

    public async Task<object> v3SignPostCoolSignin (object parameters = null)
    {
        return await this.callAsync ("v3SignPostCoolSignin",parameters);
    }

    public async Task<object> v3SignPutResetPasswordToken (object parameters = null)
    {
        return await this.callAsync ("v3SignPutResetPasswordToken",parameters);
    }

    public async Task<object> v3SignPutSignupCodeConfirm (object parameters = null)
    {
        return await this.callAsync ("v3SignPutSignupCodeConfirm",parameters);
    }

    public async Task<object> v3PrivatePostAuthWOrderSubmit (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthWOrderSubmit",parameters);
    }

    public async Task<object> v3PrivatePostAuthROrders (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthROrders",parameters);
    }

    public async Task<object> v3PrivatePostAuthROrdersMarket (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthROrdersMarket",parameters);
    }

    public async Task<object> v3PrivatePostAuthROrdersMarkets (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthROrdersMarkets",parameters);
    }

    public async Task<object> v3PrivatePostAuthApiTokensDelete (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthApiTokensDelete",parameters);
    }

    public async Task<object> v3PrivatePostAuthApiTokensCreate (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthApiTokensCreate",parameters);
    }

    public async Task<object> v3PrivatePostAuthApiTokens (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthApiTokens",parameters);
    }

    public async Task<object> v3PrivatePostAuthSigninHistoryUniq (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthSigninHistoryUniq",parameters);
    }

    public async Task<object> v3PrivatePostAuthSigninHistory (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthSigninHistory",parameters);
    }

    public async Task<object> v3PrivatePostAuthDisableWithdrawConfirmation (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthDisableWithdrawConfirmation",parameters);
    }

    public async Task<object> v3PrivatePostAuthChangePassword (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthChangePassword",parameters);
    }

    public async Task<object> v3PrivatePostAuthDepositAddress (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthDepositAddress",parameters);
    }

    public async Task<object> v3PrivatePostAuthAnnouncementsAccept (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthAnnouncementsAccept",parameters);
    }

    public async Task<object> v3PrivatePostAuthAnnouncementsUnaccepted (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthAnnouncementsUnaccepted",parameters);
    }

    public async Task<object> v3PrivatePostAuthOtpDeactivate (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthOtpDeactivate",parameters);
    }

    public async Task<object> v3PrivatePostAuthOtpActivate (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthOtpActivate",parameters);
    }

    public async Task<object> v3PrivatePostAuthOtpSecret (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthOtpSecret",parameters);
    }

    public async Task<object> v3PrivatePostAuthROrderMarketOrderIdTrades (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthROrderMarketOrderIdTrades",parameters);
    }

    public async Task<object> v3PrivatePostAuthROrdersMarketHist (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthROrdersMarketHist",parameters);
    }

    public async Task<object> v3PrivatePostAuthROrdersHist (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthROrdersHist",parameters);
    }

    public async Task<object> v3PrivatePostAuthROrdersHistMarkets (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthROrdersHistMarkets",parameters);
    }

    public async Task<object> v3PrivatePostAuthROrdersDetails (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthROrdersDetails",parameters);
    }

    public async Task<object> v3PrivatePostAuthAssetsHistory (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthAssetsHistory",parameters);
    }

    public async Task<object> v3PrivatePostAuthAssetsHistoryWithdraws (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthAssetsHistoryWithdraws",parameters);
    }

    public async Task<object> v3PrivatePostAuthAssetsHistoryDeposits (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthAssetsHistoryDeposits",parameters);
    }

    public async Task<object> v3PrivatePostAuthRWallets (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthRWallets",parameters);
    }

    public async Task<object> v3PrivatePostAuthMarketsFavorites (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthMarketsFavorites",parameters);
    }

    public async Task<object> v3PrivatePostAuthMarketsFavoritesList (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthMarketsFavoritesList",parameters);
    }

    public async Task<object> v3PrivatePostAuthMeUpdate (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthMeUpdate",parameters);
    }

    public async Task<object> v3PrivatePostAuthMe (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthMe",parameters);
    }

    public async Task<object> v3PrivatePostAuthFundSources (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthFundSources",parameters);
    }

    public async Task<object> v3PrivatePostAuthFundSourcesList (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthFundSourcesList",parameters);
    }

    public async Task<object> v3PrivatePostAuthWithdrawResendConfirmation (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthWithdrawResendConfirmation",parameters);
    }

    public async Task<object> v3PrivatePostAuthWithdraw (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthWithdraw",parameters);
    }

    public async Task<object> v3PrivatePostAuthWithdrawDetails (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthWithdrawDetails",parameters);
    }

    public async Task<object> v3PrivatePostAuthWithdrawInfo (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthWithdrawInfo",parameters);
    }

    public async Task<object> v3PrivatePostAuthPaymentAddresses (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthPaymentAddresses",parameters);
    }

    public async Task<object> v3PrivatePostAuthDepositPrerequest (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthDepositPrerequest",parameters);
    }

    public async Task<object> v3PrivatePostAuthDepositExchangeRates (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthDepositExchangeRates",parameters);
    }

    public async Task<object> v3PrivatePostAuthDeposit (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthDeposit",parameters);
    }

    public async Task<object> v3PrivatePostAuthDepositDetails (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthDepositDetails",parameters);
    }

    public async Task<object> v3PrivatePostAuthDepositInfo (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthDepositInfo",parameters);
    }

    public async Task<object> v3PrivatePostAuthKunaCodesCount (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthKunaCodesCount",parameters);
    }

    public async Task<object> v3PrivatePostAuthKunaCodesDetails (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthKunaCodesDetails",parameters);
    }

    public async Task<object> v3PrivatePostAuthKunaCodesEdit (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthKunaCodesEdit",parameters);
    }

    public async Task<object> v3PrivatePostAuthKunaCodesSendPdf (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthKunaCodesSendPdf",parameters);
    }

    public async Task<object> v3PrivatePostAuthKunaCodes (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthKunaCodes",parameters);
    }

    public async Task<object> v3PrivatePostAuthKunaCodesRedeemedByMe (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthKunaCodesRedeemedByMe",parameters);
    }

    public async Task<object> v3PrivatePostAuthKunaCodesIssuedByMe (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthKunaCodesIssuedByMe",parameters);
    }

    public async Task<object> v3PrivatePostAuthPaymentRequestsInvoice (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthPaymentRequestsInvoice",parameters);
    }

    public async Task<object> v3PrivatePostAuthPaymentRequestsType (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthPaymentRequestsType",parameters);
    }

    public async Task<object> v3PrivatePostAuthReferralProgramWeeklyEarnings (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthReferralProgramWeeklyEarnings",parameters);
    }

    public async Task<object> v3PrivatePostAuthReferralProgramStats (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthReferralProgramStats",parameters);
    }

    public async Task<object> v3PrivatePostAuthMerchantPayoutServices (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthMerchantPayoutServices",parameters);
    }

    public async Task<object> v3PrivatePostAuthMerchantWithdraw (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthMerchantWithdraw",parameters);
    }

    public async Task<object> v3PrivatePostAuthMerchantPaymentServices (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthMerchantPaymentServices",parameters);
    }

    public async Task<object> v3PrivatePostAuthMerchantDeposit (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthMerchantDeposit",parameters);
    }

    public async Task<object> v3PrivatePostAuthVerificationAuthToken (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthVerificationAuthToken",parameters);
    }

    public async Task<object> v3PrivatePostAuthKunaidPurchaseCreate (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthKunaidPurchaseCreate",parameters);
    }

    public async Task<object> v3PrivatePostAuthDevicesList (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthDevicesList",parameters);
    }

    public async Task<object> v3PrivatePostAuthSessionsList (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthSessionsList",parameters);
    }

    public async Task<object> v3PrivatePostAuthSubscriptionsReactivate (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthSubscriptionsReactivate",parameters);
    }

    public async Task<object> v3PrivatePostAuthSubscriptionsCancel (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthSubscriptionsCancel",parameters);
    }

    public async Task<object> v3PrivatePostAuthSubscriptionsProlong (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthSubscriptionsProlong",parameters);
    }

    public async Task<object> v3PrivatePostAuthSubscriptionsCreate (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthSubscriptionsCreate",parameters);
    }

    public async Task<object> v3PrivatePostAuthSubscriptionsList (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthSubscriptionsList",parameters);
    }

    public async Task<object> v3PrivatePostAuthKunaIdsList (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostAuthKunaIdsList",parameters);
    }

    public async Task<object> v3PrivatePostOrderCancelMulti (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostOrderCancelMulti",parameters);
    }

    public async Task<object> v3PrivatePostOrderCancel (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePostOrderCancel",parameters);
    }

    public async Task<object> v3PrivatePutAuthFundSourcesId (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePutAuthFundSourcesId",parameters);
    }

    public async Task<object> v3PrivatePutAuthKunaCodesRedeem (object parameters = null)
    {
        return await this.callAsync ("v3PrivatePutAuthKunaCodesRedeem",parameters);
    }

    public async Task<object> v3PrivateDeleteAuthMarketsFavorites (object parameters = null)
    {
        return await this.callAsync ("v3PrivateDeleteAuthMarketsFavorites",parameters);
    }

    public async Task<object> v3PrivateDeleteAuthFundSources (object parameters = null)
    {
        return await this.callAsync ("v3PrivateDeleteAuthFundSources",parameters);
    }

    public async Task<object> v3PrivateDeleteAuthDevices (object parameters = null)
    {
        return await this.callAsync ("v3PrivateDeleteAuthDevices",parameters);
    }

    public async Task<object> v3PrivateDeleteAuthDevicesList (object parameters = null)
    {
        return await this.callAsync ("v3PrivateDeleteAuthDevicesList",parameters);
    }

    public async Task<object> v3PrivateDeleteAuthSessionsList (object parameters = null)
    {
        return await this.callAsync ("v3PrivateDeleteAuthSessionsList",parameters);
    }

    public async Task<object> v3PrivateDeleteAuthSessions (object parameters = null)
    {
        return await this.callAsync ("v3PrivateDeleteAuthSessions",parameters);
    }

    public async Task<object> publicGetDepth (object parameters = null)
    {
        return await this.callAsync ("publicGetDepth",parameters);
    }

    public async Task<object> publicGetKWithPendingTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetKWithPendingTrades",parameters);
    }

    public async Task<object> publicGetK (object parameters = null)
    {
        return await this.callAsync ("publicGetK",parameters);
    }

    public async Task<object> publicGetMarkets (object parameters = null)
    {
        return await this.callAsync ("publicGetMarkets",parameters);
    }

    public async Task<object> publicGetOrderBook (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderBook",parameters);
    }

    public async Task<object> publicGetOrderBookMarket (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderBookMarket",parameters);
    }

    public async Task<object> publicGetTickers (object parameters = null)
    {
        return await this.callAsync ("publicGetTickers",parameters);
    }

    public async Task<object> publicGetTickersMarket (object parameters = null)
    {
        return await this.callAsync ("publicGetTickersMarket",parameters);
    }

    public async Task<object> publicGetTimestamp (object parameters = null)
    {
        return await this.callAsync ("publicGetTimestamp",parameters);
    }

    public async Task<object> publicGetTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetTrades",parameters);
    }

    public async Task<object> publicGetTradesMarket (object parameters = null)
    {
        return await this.callAsync ("publicGetTradesMarket",parameters);
    }

    public async Task<object> privateGetMembersMe (object parameters = null)
    {
        return await this.callAsync ("privateGetMembersMe",parameters);
    }

    public async Task<object> privateGetDeposits (object parameters = null)
    {
        return await this.callAsync ("privateGetDeposits",parameters);
    }

    public async Task<object> privateGetDeposit (object parameters = null)
    {
        return await this.callAsync ("privateGetDeposit",parameters);
    }

    public async Task<object> privateGetDepositAddress (object parameters = null)
    {
        return await this.callAsync ("privateGetDepositAddress",parameters);
    }

    public async Task<object> privateGetOrders (object parameters = null)
    {
        return await this.callAsync ("privateGetOrders",parameters);
    }

    public async Task<object> privateGetOrder (object parameters = null)
    {
        return await this.callAsync ("privateGetOrder",parameters);
    }

    public async Task<object> privateGetTradesMy (object parameters = null)
    {
        return await this.callAsync ("privateGetTradesMy",parameters);
    }

    public async Task<object> privateGetWithdraws (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdraws",parameters);
    }

    public async Task<object> privateGetWithdraw (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdraw",parameters);
    }

    public async Task<object> privatePostOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostOrders",parameters);
    }

    public async Task<object> privatePostOrdersMulti (object parameters = null)
    {
        return await this.callAsync ("privatePostOrdersMulti",parameters);
    }

    public async Task<object> privatePostOrdersClear (object parameters = null)
    {
        return await this.callAsync ("privatePostOrdersClear",parameters);
    }

    public async Task<object> privatePostOrderDelete (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderDelete",parameters);
    }

    public async Task<object> privatePostWithdraw (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdraw",parameters);
    }

}