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
