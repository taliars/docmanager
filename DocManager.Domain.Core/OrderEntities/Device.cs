namespace DocManager.Domain.Core.OrderEntities
{
    public class Device
    {
        public int Id { get; set; }

        public int SubscriptionId { get; set; }

        public string Name { get; set; }

        public string Use { get; set; }

        public string Number { get; set; }

        public string Range { get; set; }

        public string Fault { get; set; }

        public int VerificationInfoId { get; set; }

        public virtual VerificationInfo VerificationInfo { get; set; }
    }
}