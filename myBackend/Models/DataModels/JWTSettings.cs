namespace UniversityApiBackend.Models.DataModels
{
    public class JWTSettings
    {
        public bool ValidateIssuerSigningKey { get; set; }
        public string? IssuerSigningKey { get; set; }
        public bool ValidateIssuer { get; set; }
        public string? ValidIssuer { get; set; }
        public bool ValidateAudience { get; set; } = true;
        public string? ValidAudience { get; set; }
        public bool RequireExpirationTime { get; set; }
        public bool ValidateLifeTime { get; set; } = true;
    }
}
