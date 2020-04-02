# Facebook.NetCore.Service nuget package

A set of service to use the Facebook graph API.

This package is part of a three package group :
- [Facebook.AspNetCore.Extensions.DependencyInjection](https://github.com/pedro-de-rycker/Facebook.AspNetCore.Extensions.DependencyInjection)
- [Facebook.NetCore.Service](https://github.com/pedro-de-rycker/Facebook.NetCore.Service)
- [Facebook.NetCore.HttpClient](https://github.com/pedro-de-rycker/Facebook.NetCore.HttpClient)

## Get started

Download the following package from [nuget.org](https://www.nuget.org/) :

```
Facebook.NetCore.Service
```

## Services

### IFacebookService **[REQUIRED]**

This service is required to use the other services.

#### Constructor
```
FacebookService(string appId, string secretId)
```
Where:
- appId: represents the application ID you can find in the [Facebook developers dashboard](https://developers.facebook.com/).
- secretId: represents the secret ID you can find in the [Facebook developers dashboard](https://developers.facebook.com/).

#### Methods

##### GetApplicationTokenAsync()
Returns the application token.

### IPageService

Used to make operations on Facebook pages.

#### Methods

##### GetUserPagesAsync(string userId, string userAccessToken)
Get the pages where the user has role in it.

##### GetPageInsightsAsync(string pageId, string pageAccessToken, string metrics, string period)
Get the pages insights requested in the ``metrics`` and ``period`` parameter.

[See more](https://developers.facebook.com/docs/graph-api/reference/v6.0/insights)

##### GetPageInformationAsync(string fields, string pageId, string pageAccessToken)
Returns the page informations requested in the ``fields`` parameter.