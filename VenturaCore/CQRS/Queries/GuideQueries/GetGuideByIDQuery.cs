using MediatR;
using VenturaCore.CQRS.Results.GuideResults;

namespace VenturaCore.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery : IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}