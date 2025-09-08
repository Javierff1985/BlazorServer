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

        //carga el reporte geenral
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

        // carga los pigmentos
        public async Task<List<InkRoomCLS>> ListarPigmento()
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<List<InkRoomCLS>>("api/InkRoom/type");
                return response ?? new List<InkRoomCLS>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al consumir API: {ex.Message}");
                return new List<InkRoomCLS>(); // defensivo: nunca null
            }
        }

        //carga los colores segun cada pigmento
        public async Task<List<InkSelectColor>> ListarColor(string TypePigment)
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<List<InkSelectColor>>("api/InkRoom/inkcolor/{TypePigment}");
                return response ?? new List<InkSelectColor>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al consumir API: {ex.Message}");
                return new List<InkSelectColor>(); // defensivo: nunca null
            }
        }










    }
}
