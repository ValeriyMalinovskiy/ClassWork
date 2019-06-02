namespace _2019._05._25
{
    internal class SmartSpeaker : SmartDevice, IVoiceSwitchable
    {
        public SmartSpeaker(string name) : base(name)
        {
            this.BrandName = name;
            this.State = DeviceState.Off;
        }
    }
}
