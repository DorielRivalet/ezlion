import type { VercelRequest, VercelResponse } from "@vercel/node";
import { readFileSync } from "fs";
import { join } from "path";
type ListName = "default" | "monsters" | "armor-skills";
type DefaultValue = { name: ListName; value: Object };

const version = "v0";

const defaultValues: DefaultValue[] = [
  {
    name: "default",
    value: {
      id: 0,
      name: "Not Found",
    },
  },
  {
    name: "monsters",
    value: {
      id: 0,
      name: "None",
    },
  },
];

function findDefaultValue(listName: ListName) {
  return (
    defaultValues.find((v) => v.name === listName)?.value ??
    defaultValues[0].value
  );
}

export function respondWithDefaultValue(
  req: VercelRequest,
  res: VercelResponse,
  listName: ListName,
  returnList = true
): VercelResponse {
  try {
    if (req.method !== "GET") {
      return res
        .status(405)
        .setHeader("Content-Type", "application/problem+json")
        .json({
          type: "https://httpstatuses.com/405",
          title: "Method Not Allowed",
          status: 405,
          detail:
            "The method specified in the Request-Line is not allowed for the resource identified by the Request-URI. The Ezlion API is read-only.",
          default: findDefaultValue(listName),
        });
    }

    const url = req.url;

    if (url === undefined) {
      return res
        .status(400)
        .setHeader("Content-Type", "application/problem+json")
        .json({
          type: "https://httpstatuses.com/400",
          title: "Bad Request",
          status: 400,
          detail:
            "The server cannot or will not process the request due to something that is perceived to be a client error. The url is undefined.",
          default: findDefaultValue(listName),
        });
    }

    const dataPath = join(process.cwd(), "api", "v0", listName, "data.json");
    const data = JSON.parse(readFileSync(dataPath, "utf8"));

    if (returnList) {
      return res.status(200).json(data);
    }

    const lastSlashIndex = url.lastIndexOf("/");
    const idString = url.substring(lastSlashIndex + 1);
    const id = parseInt(idString, 10);

    if (Number.isNaN(id)) {
      return res
        .status(400)
        .setHeader("Content-Type", "application/problem+json")
        .json({
          type: "https://httpstatuses.com/400",
          title: "Bad Request",
          status: 400,
          detail:
            "The server cannot or will not process the request due to something that is perceived to be a client error. The ID is not a number.",
          default: findDefaultValue(listName),
        });
    }

    const foundID = data.results.find((m: { id: number }) => m.id === id);

    if (foundID) {
      return res.status(200).json(foundID);
    } else {
      return res
        .status(404)
        .setHeader("Content-Type", "application/problem+json")
        .json({
          type: "https://httpstatuses.com/404",
          title: "Not Found",
          status: 404,
          detail: `The origin server did not find a current representation for the target resource or is not willing to disclose that one exists. ID not found.`,
          default: findDefaultValue(listName),
        });
    }
  } catch {
    return res
      .status(500)
      .setHeader("Content-Type", "application/problem+json")
      .json({
        type: "https://httpstatuses.com/500",
        title: "Internal Server Error",
        status: 500,
        detail:
          "The server encountered an unexpected condition that prevented it from fulfilling the request. Contact the API developers for help.",
        default: findDefaultValue(listName),
      });
  }
}

export function respond(
  req: VercelRequest,
  res: VercelResponse,
  listName: ListName,
  returnList: boolean
): VercelResponse {
  try {
    if (req.method !== "GET") {
      return res
        .status(405)
        .setHeader("Content-Type", "application/problem+json")
        .json({
          type: "https://httpstatuses.com/405",
          title: "Method Not Allowed",
          status: 405,
          detail:
            "The method specified in the Request-Line is not allowed for the resource identified by the Request-URI. The Ezlion API is read-only.",
        });
    }

    const url = req.url;

    if (url === undefined) {
      return res
        .status(400)
        .setHeader("Content-Type", "application/problem+json")
        .json({
          type: "https://httpstatuses.com/400",
          title: "Bad Request",
          status: 400,
          detail:
            "The server cannot or will not process the request due to something that is perceived to be a client error. The url is undefined.",
        });
    }

    const dataPath = join(process.cwd(), "api", version, listName, "data.json");
    const data = JSON.parse(readFileSync(dataPath, "utf8"));

    if (returnList) {
      return res.status(200).json(data);
    }

    const lastSlashIndex = url.lastIndexOf("/");
    const idString = url.substring(lastSlashIndex + 1);
    const id = parseInt(idString, 10);

    if (Number.isNaN(id)) {
      return res
        .status(400)
        .setHeader("Content-Type", "application/problem+json")
        .json({
          type: "https://httpstatuses.com/400",
          title: "Bad Request",
          status: 400,
          detail:
            "The server cannot or will not process the request due to something that is perceived to be a client error. The ID is not a number.",
        });
    }

    const foundID = data.results.find((m: { id: number }) => m.id === id);

    if (foundID) {
      return res.status(200).json(foundID);
    } else {
      return res
        .status(404)
        .setHeader("Content-Type", "application/problem+json")
        .json({
          type: "https://httpstatuses.com/404",
          title: "Not Found",
          status: 404,
          detail: `The origin server did not find a current representation for the target resource or is not willing to disclose that one exists. ID not found.`,
        });
    }
  } catch {
    return res
      .status(500)
      .setHeader("Content-Type", "application/problem+json")
      .json({
        type: "https://httpstatuses.com/500",
        title: "Internal Server Error",
        status: 500,
        detail:
          "The server encountered an unexpected condition that prevented it from fulfilling the request. Contact the API developers for help.",
      });
  }
}
