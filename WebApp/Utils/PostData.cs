using NetCore_01.Models;

namespace NetCore_01.Utils
{
    public static class PostData
    {

        private static List<Post> posts;

        public static List<Post> GetPosts()
        {
            if (PostData.posts != null)
            {
                return PostData.posts;
            }

            List<Post> nuovaListaPosts = new List<Post>();

            for (int i = 0; i < 0; i++)
            {
                Post post = new Post(i, "Titolo post: " + i, "Lorem Ipsum is simply dummy text of the printing and typesetting... ", "https://picsum.photos/id/" + i + "/300/200");
                nuovaListaPosts.Add(post);
            }

            PostData.posts = nuovaListaPosts;

            return PostData.posts;

        }

    }
}