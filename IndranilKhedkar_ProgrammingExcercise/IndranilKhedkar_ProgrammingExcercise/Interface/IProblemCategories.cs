using System.Collections.Generic;

namespace IndranilKhedkar_ProgrammingExcercise.Interface
{
    interface IProblemCategories
    {
        // Returns List of Problem Categories
        List<Category> GetCategories();

        Category GetCategoryUsingValue(int categoryValue);
    }
}
