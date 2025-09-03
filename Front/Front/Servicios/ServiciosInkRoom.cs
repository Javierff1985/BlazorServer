using Datos;

namespace Front.Servicios
{
    public class ServiciosInkRoom
    {
        private List<InkRoomReportACLS> ListaGeneralFront;
        private HttpClient httpClient;

        public ServiciosInkRoom(HttpClient _httClient)
        {
            //se instancian deontro de la clase global
            ListaGeneralFront = new List<InkRoomReportACLS>();
            httpClient = _httClient;
        }

        public async Task<List<InkRoomReportACLS>> ListaGeneralAsync()
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<List<InkRoomReportACLS>>("api/InkRoom/summary");
                return response ?? new List<InkRoomReportACLS>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al consumir API: {ex.Message}");
                return new List<InkRoomReportACLS>(); // defensivo: nunca null
            }
        }





    }

}
