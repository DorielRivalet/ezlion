import type { VercelRequest, VercelResponse } from "@vercel/node";
import { SwaggerUIBundle } from "swagger-ui-dist";
import { readFileSync } from "fs";
import { join } from "path";

export default (req: VercelRequest, res: VercelResponse) => {
  try {
    const ui = SwaggerUIBundle({
      spec: JSON.parse(
        readFileSync(join(process.cwd(), "api", "docs", "swagger.json"), "utf8")
      ),
      dom_id: "#swagger-ui",
      presets: [
        SwaggerUIBundle.presets.apis,
        SwaggerUIBundle.SwaggerUIStandalonePreset,
      ],
      layout: "StandaloneLayout",
    });

    res.setHeader("Content-Type", "text/html");
    return res.send(ui);
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
};
