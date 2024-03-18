namespace Application;
public interface IAlunoApplicationService
{
Task Execute(CancellationToken CancellationToken);
}
public class AlunoApplicationService : IAlunoApplicationService
{
}