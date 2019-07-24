using Umbraco.Core;
using Umbraco.Core.Composing;

namespace IndexPopulatorTest.Core.AlbumIndex
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class AlbumIndexComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<AlbumIndexComponent>();
            composition.Register<AlbumIndexPopulator>(Lifetime.Singleton);
            composition.RegisterUnique<AlbumValueSetBuilder>();
            composition.RegisterUnique<AlbumIndexCreator>();
            composition.RegisterUnique<AlbumService>();
        }
    }
}
