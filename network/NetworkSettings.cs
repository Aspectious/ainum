namespace ainum.network
{
    public class NetworkSettings
    {
        public int LayerCount { get; set; }
        public float LearningRate { get; set; }
        public int[] NeuronsPerLayer { get; set; }
        public uint NetworkAge { get; set; }
        public bool RanndomizeValuesAtStartup { get; set; }
        public string NetworkName { get; set; }
    }
}