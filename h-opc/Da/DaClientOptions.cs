using System.Net;

namespace Hylasoft.Opc.Da
{
  /// <summary>
  /// This class defines the configuration options for the setup of the UA client session
  /// </summary>
  public class DaClientOptions
  {
    /// <summary>
    /// The identity to connect to the OPC server as
    /// </summary>
    public NetworkCredential Credentials { get; set; }

    /// <summary>
    /// Creates a client options object
    /// </summary>
    public DaClientOptions()
    {
       // Initialize default values:
       Credentials = null;
    }
  }
}
