using System.Collections.Generic;

namespace Portal.SGX.Gateway.DTO
{
    public class User
    {
        public int Id { get; set; }

        public List<PostDto> Posts { get; set; } = new List<PostDto>();
    }
}
