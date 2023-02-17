using System.Numerics;

namespace Instek4303s.Data.Models
{
    public static class PanelSettings
    {
        public static Dictionary<int, Channel> Channels = new Dictionary<int, Channel>()
        {
            {1, new UnscaledChannel(new ChannelSettings<float>(30, 5)) },
            {2, new UnscaledChannel(new ChannelSettings<float>(30, 5)) },
            {3, new ScaledChannel(new ChannelSettings<Vector2>(new Vector2(5, 10), new Vector2(3, 1))) },
            {4, new UnscaledChannel(new ChannelSettings<float>(10, 1)) }
        };

        public static void SetTest()
        {
            Channels[1].Voltage = 500;
        }
    }
}
