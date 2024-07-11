namespace CustomPackaging
{
    internal sealed class Metadata
    {
        public static class Traits
        {
            public const string CustomPackaging = nameof(CustomPackaging);
            public const string CustomPackagingConversion = nameof(CustomPackagingConversion);
        }

        public static class SliceNodeKinds
        {
            public const string CustomPackaging = nameof(CustomPackaging);
        }

        public static class SliceNodeOrder
        {
            public const int CustomPackaging = UAMetadata.SliceNodesOrder.DependenciesFinalizer - 10; // Ensure it runs before the dependency finalizer
        }
    }
}
