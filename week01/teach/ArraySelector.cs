public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var result = new int[select.Length];
        var li1 = 0;
        var li2 = 0;
        for (var i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                result[i] = list1[li1++];
            }
            if (select[i] == 2)
            {
                result[i] = list2[li2++];
            }
        }
        return result;
    }
    // private static List<int> ListSelector(int[] list1, int[] list2, int[] select)
    // {
    //     List<int> result = [];
    //     var capy = select.Length;
    //     var l1ind = 0;
    //     var l2ind = 0;
    //     for(var i = 0; i < capy; i++)
    //     {
    //         if (select[i] == 1)
    //         {
    //             result.Add(list1[l1ind++]);
    //         }
    //         if (select[i] == 2)
    //         {
    //             result.Add(list2[l2ind++]);
    //         }

    //     }
    //     return result;
    // }
}