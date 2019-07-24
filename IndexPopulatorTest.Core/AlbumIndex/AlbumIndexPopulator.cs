using Examine;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Examine;

namespace IndexPopulatorTest.Core.AlbumIndex
{
    public class AlbumIndexPopulator : IndexPopulator
    {
        private readonly AlbumValueSetBuilder _albumValueSetBuilder;
        private readonly AlbumService _albumService;

        public AlbumIndexPopulator(AlbumValueSetBuilder albumValueSetBuilder, AlbumService albumservice)
        {
            _albumValueSetBuilder = albumValueSetBuilder;
            _albumService = albumservice;

            RegisterIndex("AlbumIndex");
        }

        protected override void PopulateIndexes(IReadOnlyList<IIndex> indexes)
        {
            var albums = _albumService.GetAlbums();

            if (albums != null && albums.Any())
            {
                foreach (var index in indexes)
                {
                    foreach (var album in albums)
                    {
                        index.IndexItems(
                        _albumValueSetBuilder.GetValueSets(album));
                    }
                }
            }
        }
    }
}
