using Examine;
using Examine.LuceneEngine.Providers;
using Lucene.Net.Analysis.Standard;
using System.Collections.Generic;
using Umbraco.Examine;

namespace IndexPopulatorTest.Core.AlbumIndex
{
    public class AlbumIndexCreator : LuceneIndexCreator
    {
        public override IEnumerable<IIndex> Create()
        {
            var index = new LuceneIndex("AlbumIndex",
            CreateFileSystemLuceneDirectory("AlbumIndex"),
            //by default, all fields are just "FullText"
            new FieldDefinitionCollection(
                new FieldDefinition("id", FieldDefinitionTypes.Integer),
                new FieldDefinition("Title", FieldDefinitionTypes.FullTextSortable)),
            new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30));

            return new[] { index };
        }
    }
}
