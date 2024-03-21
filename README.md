# EZlion

<center>
  <img src='./assets/logo-alt.svg'>
  <div>
    <i>Data retrieval, made easy.</i>
  </div>
</center>

- NuGet ![NuGet](https://img.shields.io/nuget/dt/EZlion)
- npm ![npm](https://img.shields.io/npm/dt/ezlion)

A data retrieval and translation project for Monster Hunter Frontier Z

## API

It is recommended to host the API yourself. You can do so by doing the following:

1. Fork the [repository](https://github.com/DorielRivalet/ezlion/fork).
2. Deploy the project following the instructions [here](https://vercel.com/docs/deployments/git#deploying-a-git-repository).
3. Confirm if it worked correctly by checking the API Reference at `https://yourprojectname.vercel.app/api/docs`.

### Usage

The API is static, you can only use the `GET` HTTP method.

We provide the following data, for example:

- Request: Get monster by id

```bash
curl https://yourprojectname.vercel.app/api/v0/monsters/1
```

- Response:

```json
{ "id": 1, "name": "Rathian" }
```

- Request: Get monsters

```bash
curl https://yourprojectname.vercel.app/api/v0/monsters
```

- Response:

```json
{
  "results": [
    { "id": 0, "name": "None" },
    { "id": 1, "name": "Rathian" },
    { "id": 2, "name": "Rathalos" }
  ],
  "metadata": {
    "readonly": true,
    "repository": "https://github.com/DorielRivalet/ezlion"
  }
}
```

For more information, consult the documentation [here](./docs/README.adoc#API).
