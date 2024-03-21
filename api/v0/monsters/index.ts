import { readFileSync } from "fs";
import { join } from "path";
import type { VercelRequest, VercelResponse } from "@vercel/node";

const defaultValue = {
  id: 0,
  name: "None",
};

export default (req: VercelRequest, res: VercelResponse) => {
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
          default: defaultValue,
        });
    }

    const dataPath = join(process.cwd(), "api", "v0", "monsters", "data.json");
    const data = JSON.parse(readFileSync(dataPath, "utf8"));
    return res.status(200).json(data.results);
  } catch (err) {
    return res
      .status(500)
      .setHeader("Content-Type", "application/problem+json")
      .json({
        type: "https://httpstatuses.com/500",
        title: "Internal Server Error",
        status: 500,
        detail:
          "The server encountered an unexpected condition that prevented it from fulfilling the request. Contact the API developers for help.",
        default: defaultValue,
      });
  }
};
