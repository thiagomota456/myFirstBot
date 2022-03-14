using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSearchGitHub
{
    public class Repository
    {
        public long id { get; set; }
        public string node_id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        
        //"owner": {
        //"login": "takenet",
        //"id": 4369522,
        //"node_id": "MDEyOk9yZ2FuaXphdGlvbjQzNjk1MjI=",
        //"avatar_url": "https://avatars.githubusercontent.com/u/4369522?v=4",
        //"gravatar_id": "",
        public string url { get; set; }
        //"html_url": "https://github.com/takenet",
        //"followers_url": "https://api.github.com/users/takenet/followers",
        //"following_url": "https://api.github.com/users/takenet/following{/other_user}",
        //"gists_url": "https://api.github.com/users/takenet/gists{/gist_id}",
        //"starred_url": "https://api.github.com/users/takenet/starred{/owner}{/repo}",
        //"subscriptions_url": "https://api.github.com/users/takenet/subscriptions",
        //"organizations_url": "https://api.github.com/users/takenet/orgs",
        //"repos_url": "https://api.github.com/users/takenet/repos",
        //"events_url": "https://api.github.com/users/takenet/events{/privacy}",
        //"received_events_url": "https://api.github.com/users/takenet/received_events",
        //"type": "Organization",
        //"site_admin": false
        //},
        //"html_url": "https://github.com/takenet/.github",
        public string description { get; set; }
        //"fork": false,
        //"url": "https://api.github.com/repos/takenet/.github",
        //"forks_url": "https://api.github.com/repos/takenet/.github/forks",
        //"keys_url": "https://api.github.com/repos/takenet/.github/keys{/key_id}",
        //"collaborators_url": "https://api.github.com/repos/takenet/.github/collaborators{/collaborator}",
        //"teams_url": "https://api.github.com/repos/takenet/.github/teams",
        //"hooks_url": "https://api.github.com/repos/takenet/.github/hooks",
        //"issue_events_url": "https://api.github.com/repos/takenet/.github/issues/events{/number}",
        //"events_url": "https://api.github.com/repos/takenet/.github/events",
        //"assignees_url": "https://api.github.com/repos/takenet/.github/assignees{/user}",
        //"branches_url": "https://api.github.com/repos/takenet/.github/branches{/branch}",
        //"tags_url": "https://api.github.com/repos/takenet/.github/tags",
        //"blobs_url": "https://api.github.com/repos/takenet/.github/git/blobs{/sha}",
        //"git_tags_url": "https://api.github.com/repos/takenet/.github/git/tags{/sha}",
        //"git_refs_url": "https://api.github.com/repos/takenet/.github/git/refs{/sha}",
        //"trees_url": "https://api.github.com/repos/takenet/.github/git/trees{/sha}",
        //"statuses_url": "https://api.github.com/repos/takenet/.github/statuses/{sha}",
        //"languages_url": "https://api.github.com/repos/takenet/.github/languages",
        //"stargazers_url": "https://api.github.com/repos/takenet/.github/stargazers",
        //"contributors_url": "https://api.github.com/repos/takenet/.github/contributors",
        //"subscribers_url": "https://api.github.com/repos/takenet/.github/subscribers",
        //"subscription_url": "https://api.github.com/repos/takenet/.github/subscription",
        //"commits_url": "https://api.github.com/repos/takenet/.github/commits{/sha}",
        //"git_commits_url": "https://api.github.com/repos/takenet/.github/git/commits{/sha}",
        //"comments_url": "https://api.github.com/repos/takenet/.github/comments{/number}",
        //"issue_comment_url": "https://api.github.com/repos/takenet/.github/issues/comments{/number}",
        //"contents_url": "https://api.github.com/repos/takenet/.github/contents/{+path}",
        //"compare_url": "https://api.github.com/repos/takenet/.github/compare/{base}...{head}",
        //"merges_url": "https://api.github.com/repos/takenet/.github/merges",
        //"archive_url": "https://api.github.com/repos/takenet/.github/{archive_format}{/ref}",
        //"downloads_url": "https://api.github.com/repos/takenet/.github/downloads",
        //"issues_url": "https://api.github.com/repos/takenet/.github/issues{/number}",
        //"pulls_url": "https://api.github.com/repos/takenet/.github/pulls{/number}",
        //"milestones_url": "https://api.github.com/repos/takenet/.github/milestones{/number}",
        //"notifications_url": "https://api.github.com/repos/takenet/.github/notifications{?since,all,participating}",
        //"labels_url": "https://api.github.com/repos/takenet/.github/labels{/name}",
        //"releases_url": "https://api.github.com/repos/takenet/.github/releases{/id}",
        //"deployments_url": "https://api.github.com/repos/takenet/.github/deployments",
        private DateTime _created_at;
        public DateTime created_at { get { return _created_at; } set { _created_at = Convert.ToDateTime(value); } }
        //"updated_at": "2021-02-09T17:19:30Z",
        //"pushed_at": "2021-02-09T17:19:27Z",
        //"git_url": "git://github.com/takenet/.github.git",
        //"ssh_url": "git@github.com:takenet/.github.git",
        //"clone_url": "https://github.com/takenet/.github.git",
        //"svn_url": "https://github.com/takenet/.github",
        //"homepage": null,
        //"size": 3,
        //"stargazers_count": 0,
        //"watchers_count": 0,
        //"language": null,
        //"has_issues": true,
        //"has_projects": true,
        //"has_downloads": true,
        //"has_wiki": true,
        //"has_pages": false,
        //"forks_count": 0,
        //"mirror_url": null,
        //"archived": false,
        //"disabled": false,
        //"open_issues_count": 0,
        //"license": null,
        //"allow_forking": true,
        //"is_template": false,
        //"topics": [],
        //"visibility": "public",
        //"forks": 0,
        //"open_issues": 0,
        //"watchers": 0,
        //"default_branch": "master"
    }
}
