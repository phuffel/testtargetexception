using ServiceStack;
using DataCenterServiceSelfHost.ServiceModel;


namespace DataCenterServiceSelfHost.ServiceInterface
{
    public class FieldValidationServices : Service
    {

        public object Get(ValidationDesEmissionRequest request)
        {

            var ResultValidation = new ResultValidationDesEmission()
            {
                FirstSymbolTypeOfModulationOfMainCarrier = "test",
                FirstSymbolDescription = "test",
                SecondSymbolNatureOfSignalsModulatingMainCarrier = "test",
                SecondSymbolDescription = "test",
                ThirdSymbolTypeOfInformationToBeTransmitted = "test",
                ThirdSymbolDescription = "test",
                FourthSymbolDetailsOfSignals = "test",
                FourthSymbolDescription = "test",
                FifthSymbolNatureOfMultiplexing = "test",
                FifthSymbolDescription = "test",
                PART1 = "test",
                PART2 = "test",
                BW = 0.0,
                ErrorCode = "test",

                TimeOfResponse = System.DateTime.Now.ToString()
            };

            return new ValidationDesEmissionResponse { Result = ResultValidation };
        }

    }
}
