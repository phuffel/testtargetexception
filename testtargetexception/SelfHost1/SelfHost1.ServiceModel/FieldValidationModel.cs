using ServiceStack;

namespace DataCenterServiceSelfHost.ServiceModel
{
    [Route("/validate/desemission", Summary = @"Validation of a Designation of Emission field.", Notes = "Compiles and validates a designation of emission field.")]
    public class ValidationDesEmissionRequest : IReturn<ValidationDesEmissionResponse>
    {
        [ApiMember(Description = "Code having a format of max 9 characters, example: 14K0F3E--", IsRequired = true)]
        public string CodeToBeTested { get; set; }

    }

    public class ValidationDesEmissionResponse
    {
        public ResultValidationDesEmission Result { get; set; }
    }

    public class ResultValidationDesEmission
    {
        public string FirstSymbolTypeOfModulationOfMainCarrier { get; set; }

        public string FirstSymbolDescription { get; set; }

        public string SecondSymbolNatureOfSignalsModulatingMainCarrier { get; set; }

        public string SecondSymbolDescription { get; set; }

        public string ThirdSymbolTypeOfInformationToBeTransmitted { get; set; }

        public string ThirdSymbolDescription { get; set; }

        public string FourthSymbolDetailsOfSignals { get; set; }

        public string FourthSymbolDescription { get; set; }

        public string FifthSymbolNatureOfMultiplexing { get; set; }

        public string FifthSymbolDescription { get; set; }

        public string PART1 { get; set; }

        public string PART2 { get; set; }

        public double BW { get; set; }

        public string ErrorCode { get; set; }

        public string TimeOfResponse { get; set; }
    }
       

}
