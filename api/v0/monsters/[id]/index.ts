import { readFileSync } from "fs";
import { join } from "path";
import type { VercelRequest, VercelResponse } from "@vercel/node";

export default (req: VercelRequest, res: VercelResponse) => {
  try {
    if (req.method !== "GET") {
      return res.status(405).json({ error: "Method Not Allowed" });
    }

    const url = req.url; // Assuming req.url contains the full URL path

    if (url === undefined) {
      return res.status(400).json({ error: `Bad response.` });
    }

    const lastSlashIndex = url.lastIndexOf("/");
    const idString = url.substring(lastSlashIndex + 1);
    const id = parseInt(idString, 10);

    if (Number.isNaN(id)) {
      return res.status(400).json({
        error: `Bad response.`,
      });
    }

    const dataPath = join(process.cwd(), "api", "v0", "monsters", "data.json");
    const data = JSON.parse(readFileSync(dataPath, "utf8"));
    const monster = data.results.find((m: { id: number }) => m.id === id);

    if (monster) {
      return res.status(200).json(monster);
    } else {
      return res.status(404).json({ error: `Monster id ${id} not found` });
    }
  } catch (err) {
    return res.status(500).json({ error: "Internal Server Error" });
  }
};
