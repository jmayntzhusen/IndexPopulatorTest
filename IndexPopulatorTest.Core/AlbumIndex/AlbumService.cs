using Newtonsoft.Json;
using System.Collections.Generic;

namespace IndexPopulatorTest.Core.AlbumIndex
{
    public class AlbumService
    {
        public IEnumerable<Album> GetAlbums()
        {
            string json = @"[
                {
                    id: 1,
                    title: 'quidem molestiae enim'
                },
                {
                    id: 2,
                    title: 'sunt qui excepturi placeat culpa'
                },
                {
                    id: 3,
                    title: 'omnis laborum odio'
                },
                {
                    id: 4,
                    title: 'non esse culpa molestiae omnis sed optio'
                },
                {
                    id: 5,
                    title: 'eaque aut omnis a'
                }]";

            IEnumerable<Album> albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(json);

            return albums;
        }
    }
}
