public class SimpleDataBase
<T>
{
    List<T> storedData;
    List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        int count = 0;
        storedData.ForEach(delegate (T data)
        {
            Console.WriteLine($"Data {count + 1} berisi: {data}, yang disimpan pada waktu UTC: {inputDates[count]}");
            count++;
        });
    }


}