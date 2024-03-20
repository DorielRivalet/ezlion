import { readFileSync } from "fs";
import { join } from "path";
import type { VercelRequest, VercelResponse } from "@vercel/node";

export default (req: VercelRequest, res: VercelResponse) => {
  try {
    if (req.method !== "GET") {
      return res.status(405).json({ error: "Method Not Allowed" });
    }

    const dataPath = join(__dirname, "data.json");
    const data = JSON.parse(readFileSync(dataPath, "utf8"));
    return res.status(200).json(data.results);
  } catch (err) {
    return res.status(500).json({ error: "Internal Server Error" });
  }
};
