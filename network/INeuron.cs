namespace ainum.network
{
    public interface INeuron
    {
        void Simulate();
        float[] GetWeights();
        float GetActivation();
        float GetBias();
        bool setWeights(float[] weights);
        bool setBias(float bias);
        bool randomizeWeightsAndBias();
    }
}