open System

[<EntryPoint>]
let main argv =
    let token = System.Environment.GetEnvironmentVariable("GITHUB_TOKEN")
    let client = new GitHubClient(new ProductHeaderValue("example"))
    let basicAuth = new Credentials(token)

    0
