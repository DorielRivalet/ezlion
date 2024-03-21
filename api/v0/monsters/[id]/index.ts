import { readFileSync } from "fs";
import { join } from "path";
import type { VercelRequest, VercelResponse } from "@vercel/node";

export default (req: VercelRequest, res: VercelResponse) => {
  try {
    if (req.method !== "GET") {
      return res.status(405).json({
        type: "https://httpstatuses.com/405",
        title: "Method Not Allowed",
        status: 405,
        detail:
          "The method specified in the Request-Line is not allowed for the resource identified by the Request-URI. The Ezlion API is read-only.",
      });
    }

    const url = req.url;

    if (url === undefined) {
      return res.status(400).json({
        type: "https://httpstatuses.com/400",
        title: "Bad Request",
        status: 400,
        detail:
          "The server cannot or will not process the request due to something that is perceived to be a client error. The url is undefined.",
      });
    }

    const lastSlashIndex = url.lastIndexOf("/");
    const idString = url.substring(lastSlashIndex + 1);
    const id = parseInt(idString, 10);

    if (Number.isNaN(id)) {
      return res.status(400).json({
        type: "https://httpstatuses.com/400",
        title: "Bad Request",
        status: 400,
        detail:
          "The server cannot or will not process the request due to something that is perceived to be a client error. The id is not a number.",
      });
    }

    const dataPath = join(process.cwd(), "api", "v0", "monsters", "data.json");
    const data = JSON.parse(readFileSync(dataPath, "utf8"));
    const monster = data.results.find((m: { id: number }) => m.id === id);

    if (monster) {
      return res.status(200).json(monster);
    } else {
      return res.status(404).json({
        type: "https://httpstatuses.com/404",
        title: "Not Found",
        status: 404,
        detail: `The origin server did not find a current representation for the target resource or is not willing to disclose that one exists. Monster id not found.`,
      });
    }
  } catch (err) {
    return res.status(500).json({
      type: "https://httpstatuses.com/500",
      title: "Internal Server Error",
      status: 500,
      detail:
        "The server encountered an unexpected condition that prevented it from fulfilling the request. Contact the API developers for help.",
    });
  }
};
