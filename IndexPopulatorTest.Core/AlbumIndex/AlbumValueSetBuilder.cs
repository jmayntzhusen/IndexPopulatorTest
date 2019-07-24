using Examine;
using System.Collections.Generic;
using Umbraco.Examine;

namespace IndexPopulatorTest.Core.AlbumIndex
{
    public class AlbumValueSetBuilder : IValueSetBuilder<Album>
    {
        public IEnumerable<ValueSet> GetValueSets(params Album[] albums)
        {
            foreach (var album in albums)
            {
                var indexValues = new Dictionary<string, object>
                {
                    ["id"] = album.Id,
                    ["title"] = album.Title
                };

                var valueSet = new ValueSet(album.Id.ToString(), "album", indexValues);

                yield return valueSet;
            }
        }
    }
}
