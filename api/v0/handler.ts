import type { VercelRequest, VercelResponse } from "@vercel/node";
import { readFileSync } from "fs";
import { join } from "path";

type ListName =
  | "default"
  | "armor-arms"
  | "armor-colors"
  | "armor-chests"
  | "armor-heads"
  | "armor-legs"
  | "armor-waists"
  | "items"
  | "locations"
  | "monsters"
  | "objective-types"
  | "poogie-costumes"
  | "poogie-guild-outfits"
  | "quest-toggle-modes"
  | "quests"
  | "rank-bands"
  | "sharpness"
  | "skills-armor"
  | "skills-armor-priority"
  | "skills-caravan"
  | "skills-diva"
  | "skills-diva-prayer-gem"
  | "skills-guild-poogie"
  | "skills-halk"
  | "skills-road-tower"
  | "skills-sigil"
  | "skills-style-rank"
  | "skills-tree"
  | "skills-zenith"
  | "weapon-classes"
  | "weapon-styles"
  | "weapon-types"
  | "weapons-blademaster"
  | "weapons-gunner";
type DefaultValue = { name: ListName; value: { id: number; name: string } };

const version = "v0";
const defaultValues: DefaultValue[] = [
  {
    name: "default",
    value: {
      id: 0,
      name: "None",
    },
  },
  {
    name: "monsters",
    value: {
      id: 0,
      name: "None",
    },
  },
  {
    name: "locations",
    value: {
      id: 0,
      name: "Loading",
    },
  },
  {
    name: "poogie-costumes",
    value: {
      id: 0,
      name: "First Costume",
    },
  },
  {
    name: "poogie-guild-outfits",
    value: {
      id: 0,
      name: "Red & White",
    },
  },
  {
    name: "sharpness",
    value: {
      id: 0,
      name: "Red",
    },
  },
  {
    name: "skills-armor-priority",
    value: {
      id: 0,
      name: "SnS Tech",
    },
  },
  {
    name: "skills-style-rank",
    value: {
      id: 0,
      name: "Nothing",
    },
  },
  {
    name: "weapon-classes",
    value: {
      id: 0,
      name: "Blademaster",
    },
  },
  {
    name: "weapon-styles",
    value: {
      id: 0,
      name: "Earth Style",
    },
  },
  {
    name: "weapon-types",
    value: {
      id: 0,
      name: "Great Sword",
    },
  },
  {
    name: "armor-heads",
    value: {
      id: 0,
      name: "No Equipment",
    },
  },
  {
    name: "armor-arms",
    value: {
      id: 0,
      name: "No Equipment",
    },
  },
  {
    name: "armor-waists",
    value: {
      id: 0,
      name: "No Equipment",
    },
  },
  {
    name: "armor-legs",
    value: {
      id: 0,
      name: "No Equipment",
    },
  },
  {
    name: "armor-chests",
    value: {
      id: 0,
      name: "No Equipment",
    },
  },
  {
    name: "armor-colors",
    value: {
      id: 0,
      name: "Material Green 0",
    },
  },
  {
    name: "objective-types",
    value: {
      id: 0,
      name: "Nothing",
    },
  },
  {
    name: "quest-toggle-modes",
    value: {
      id: 0,
      name: "Normal",
    },
  },
  {
    name: "rank-bands",
    value: {
      id: 0,
      name: "Lower",
    },
  },
  {
    name: "skills-tree",
    value: {
      id: 0,
      name: "",
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

/** unused? */
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
