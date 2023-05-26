namespace MessageContracts
{
  public record MessageFromBff(string Description, DateTime Timestamp);
  public record MessageFromProcessingService(string Description, DateTime Timestamp);
}
