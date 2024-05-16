SSL Checker API
============

SSL Checker is a simple tool for checking SSL certificates. It returns the SSL certificate details of a website.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [SSL Checker API](https://apiverve.com/marketplace/api/sslchecker)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.SSLChecker
```

Using the Package Manager:
```
nuget install APIVerve.API.SSLChecker
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.SSLChecker
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.SSLChecker".
5. Click on the APIVerve.API.SSLChecker package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the sslchecker API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The SSL Checker API documentation is found here: [https://docs.apiverve.com/api/sslchecker](https://docs.apiverve.com/api/sslchecker).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
SSL Checker API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new SSLCheckerAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new sslcheckerQueryOptions {
  url = "https://ebay.com"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "subject": {
      "C": "US",
      "ST": "California",
      "O": "eBay, Inc.",
      "CN": "ebay.com"
    },
    "issuer": {
      "C": "GB",
      "ST": "Greater Manchester",
      "L": "Salford",
      "O": "Sectigo Limited",
      "CN": "Sectigo RSA Organization Validation Secure Server CA"
    },
    "subjectaltname": "DNS:ebay.com, DNS:befr.ebay.be, DNS:benl.ebay.be, DNS:cafr.ebay.ca, DNS:e-bay.it, DNS:ebay.at, DNS:ebay.be, DNS:ebay.ca, DNS:ebay.ch, DNS:ebay.co.uk, DNS:ebay.com.au, DNS:ebay.com.hk, DNS:ebay.com.my, DNS:ebay.com.sg, DNS:ebay.de, DNS:ebay.es, DNS:ebay.fr, DNS:ebay.ie, DNS:ebay.in, DNS:ebay.it, DNS:ebay.nl, DNS:ebay.ph, DNS:ebay.pl, DNS:ebay.us, DNS:ebay.vn",
    "infoAccess": {
      "CA Issuers - URI": [
        "http://crt.sectigo.com/SectigoRSAOrganizationValidationSecureServerCA.crt"
      ],
      "OCSP - URI": [
        "http://ocsp.sectigo.com"
      ]
    },
    "ca": false,
    "bits": 2048,
    "valid_from": "Feb 26 00:00:00 2024 GMT",
    "valid_to": "Feb 25 23:59:59 2025 GMT",
    "serialNumber": "D5072F2C3B21834D34FBB048F9A5DAC0"
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.