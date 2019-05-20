namespace Equinox.Infra.CrossCutting.Logger
{
    public static class SerilogStringTemplates
    {
        public static string MiddlewareMessageTemplate = "InstanceId {instanceId} HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms";

        public static string ValidationStaffMessageTemplate = "TypeValidator {Type} Dni {dni} message validator {message}";
    }
}
