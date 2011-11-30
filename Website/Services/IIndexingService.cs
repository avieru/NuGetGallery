using System.Collections.Generic;

namespace NuGetGallery
{
    public interface IIndexingService
    {
        void CreateIndex(IEnumerable<Package> packages);

        void UpdateIndex(Package package);

        IEnumerable<int> Search(string term);
    }
}