namespace MSR.CVE.BackMaker.ImagePipeline
{
    public class HashableImmutableParameter<T> : ImmutableParameter<T> where T : IRobustlyHashable
    {
        public HashableImmutableParameter(T value) : base(value)
        {
        }

        public override void AccumulateRobustHash(IRobustHash hash)
        {
            T value = this.value;
            value.AccumulateRobustHash(hash);
        }
    }
}
