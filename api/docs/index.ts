import type { VercelRequest, VercelResponse } from "@vercel/node";
import { SwaggerUIBundle } from "swagger-ui-dist";

export default (req: VercelRequest, res: VercelResponse) => {
  const swaggerHtml = SwaggerUIBundle({
    url: "/api/docs/swagger.json",
    dom_id: "#swagger-ui",
    presets: [
      SwaggerUIBundle.presets.apis,
      SwaggerUIBundle.SwaggerUIStandalonePreset,
    ],
    layout: "StandaloneLayout",
  });

  res.setHeader("Content-Type", "text/html");
  res.send(swaggerHtml);
};
