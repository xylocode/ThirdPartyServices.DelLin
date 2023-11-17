# Delovye Linii API client library

An unofficial .NET client library for accessing the Delovye Linii API.

- [NuGet](https://www.nuget.org/packages/XyloCode.ThirdPartyServices.DelLin) (.NET library)
- [GitHub](https://github.com/xylocode/ThirdPartyServices.DelLin) (source code)
- [Official documentation](https://dev.dellin.ru/api/)

#### Supported Platforms

- .NET 6.0 LTS;
- .NET 7.0;
- .NET 8.0 LTS.

## "Delovye Linii"

Delovye Linii Group Company, founded in 2001, reaches more than 90% of the locations in Russia, with its delivery services extended to Belarus, Kazakhstan, Kyrgyzstan, Armenia, China, East Asia and Europe. The company is ranked first in the reliability rating of consolidated cargo carriers ('Public Consumer Initiative', 2023) and first in terms of warehouse space in Russia's regions (as reported by Knight Frank, 2021). The company's headquarters is located in St. Petersburg.

Official website: [https://www.dellin.ru/](https://www.dellin.ru/).

## Supported Methods

- Authorization
	- User authorization
		- Authorization
		- Closing the current session
		- Data on the current session
	- Available counterparties
- Calculation
	- Shipping Cost and Time Calculator
	- Estimated Shipping Cost and Time
- Placing an order
	- Placing LTL orders
- Order Information
	- Orders list
	- Order status history
- Terminals
	- Terminals directory
- Locations
	- Geographical directories
		- Directory of Countries
		- Directory of Cities
		- Directory of Cities with payment restrictions
		- Directory of Streets
- Auxiliary
	- Directories
		- Directory of additional services
		- Nature of cargo
		- Documents for receipt of cargo
		- Directory of parameters for statistics report
		- Directory of vehicle loading types
		- Directory of special transport requirements
		- Directory of packages
		- Directory of order statuses
		- Event types
- Marking
	- Cargo places labeling
		- Passing the packages code numbers
		- Getting the labels for packages
	- Handling labels
		- Handling labels directory
		- Getting the handling labels
	- Packaging labels
		- Packaging labels directory
		- Getting the packaging labels


## How to use

```cs
using XyloCode.ThirdPartyServices.DelLin;
using XyloCode.ThirdPartyServices.DelLin.Enums;
using XyloCode.ThirdPartyServices.DelLin.Helpers;
using XyloCode.ThirdPartyServices.DelLin.Calc1.Req;
using XyloCode.ThirdPartyServices.DelLin.Models;

namespace DelLinTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 	The application key. To get the key, register on https://dev.dellin.ru/
            const string appkey = "00000000-0000-0000-0000-000000000000";


            var tracer = new LoggingHandler(); // // for tracing, needed only for debugging
            var api = new DellinClient(appkey, httpMessageHandler: tracer);
            api.Login("+79XXXXXXXXX", "my_password");

            // Order status history
            var tracker = api.GetOrderStatuses("12345678");


            // Calculation
            var calculationRequest = new CalculationRequest
            {
                Delivery = new Delivery
                {
                    DeliveryType = new DeliveryType { Type = DeliveryTypeCode.Avia },
                    Derival = new DerivalArrival
                    {
                        ProduceDate = DateOnly.FromDateTime(DateTime.Today.AddDays(3)),
                        Variant = ArrivalEndpoint.Address,
                        Address = new Address("Город Москва, ул Вавилова, д. 19"),
                        Time = new Time
                        {
                            WorktimeStart = new TimeOnly(10, 0),
                            WorktimeEnd = new TimeOnly(16, 0),
                            ExactTime = false,
                        }
                    },
                    Arrival = new DerivalArrival
                    {
                        Variant = ArrivalEndpoint.Address,
                        Address = new Address("630099, Новосибирская область, г Новосибирск, пр-кт Димитрова, зд. 2"),
                        Time = new Time
                        {
                            WorktimeStart = new TimeOnly(9, 0),
                            WorktimeEnd = new TimeOnly(17, 0),
                            ExactTime = false,
                        }
                    },
                },
                Cargo = new Cargo
                {
                    Quantity = 1,
                    Weight = 1.5f,
                    Length = 0.2f,
                    Height = 0.1f,
                    Width = 0.1f,
                    TotalVolume = 0.01f,
                    TotalWeight = 1.5f,
                    Insurance = new Insurance { StatedValue = 70_000, Term = true, }
                },

                Payment = new Payment
                {
                    PaymentCitySearch = new Search("Новосибирск"),
                    Type = PaymentType.NonCash,
                },


                Members = new Members
                {
                    Requester = new Requester
                    {
                        Uid = "30A23C53-6080-4FD8-9681-A42EEA4B5209",
                        Role = RoleType.Third,
                    }
                }

            };
            var calculationResult = api.Calculation(calculationRequest);
            api.Logout();
        }
    }
}
```

## Known Issues

70% of Russian addresses indicated in accordance with the [Federal Address Information System](https://fias.nalog.ru/) are rejected by the Delovye Linii API information system. This becomes a serious obstacle to further automation, this applies to such functionality as Shipping Cost & Time Calculator and Placing LTL orders. Make official requests directly to your manager at the Delovye Linii group of companies, by [email](mailto:api_support@dellin.ru) or through the [request management system](https://helpdesk.dellin.ru/).

## License

MIT License
