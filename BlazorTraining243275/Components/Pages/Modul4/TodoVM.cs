namespace BlazorTraining243275.Components.Pages.Modul4
{
    public class TodoVM
    {
        public ToDoModel ToDoObjekt { get; set; }
        IHttpClientFactory http;
        public TodoVM(IHttpClientFactory _http)
        {
             http = _http;
            using (var client = http.CreateClient())
            {
               //ToDoObjekt = await client.GetFromJsonAsync<ToDoModel>("https://dummyjson.com/todos");
            }

        }
    }
}
