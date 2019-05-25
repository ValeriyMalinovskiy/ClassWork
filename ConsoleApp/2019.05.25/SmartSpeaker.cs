namespace _2019._05._25
{
    internal class SmartSpeaker : SmartDevice, IVoiceSwitchable
    {
        public override string BrandName { get; protected set; }

        public override bool IsDeviceOn { get; set; }

        public SmartSpeaker(string name) : base(name)
        {
            this.BrandName = name;
            this.IsDeviceOn = true;
        }
    }
}
