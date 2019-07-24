using Examine;
using Umbraco.Core.Composing;

namespace IndexPopulatorTest.Core.AlbumIndex
{
    public class AlbumIndexComponent : IComponent
    {
        private readonly IExamineManager _examineManager;
        private readonly AlbumIndexCreator _indexCreator;

        public AlbumIndexComponent(IExamineManager examineManager, AlbumIndexCreator indexCreator)
        {
            _examineManager = examineManager;
            _indexCreator = indexCreator;
        }

        public void Initialize()
        {
            foreach (var index in _indexCreator.Create())
                _examineManager.AddIndex(index);
        }

        public void Terminate()
        {
        }
    }
}
