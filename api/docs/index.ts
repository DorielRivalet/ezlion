import { readFileSync } from "fs";
import { join } from "path";
import type { VercelRequest, VercelResponse } from "@vercel/node";

export default (req: VercelRequest, res: VercelResponse) => {
  try {
    // Path to your custom Swagger UI HTML file
    const swaggerHtmlPath = join(
      process.cwd(),
      "api",
      "docs",
      "swagger-ui.html"
    );
    let swaggerHtml = readFileSync(swaggerHtmlPath, "utf8");

    // Path to your custom CSS file
    const customCssPath = join(process.cwd(), "api", "docs", "catppuccin.css");
    const customCss = readFileSync(customCssPath, "utf8");

    // Inject the custom CSS into the HTML
    swaggerHtml = swaggerHtml.replace(
      "</head>",
      `<style>${customCss}</style></head>`
    );

    res.setHeader("Content-Type", "text/html");
    return res.send(swaggerHtml);
  } catch (error) {
    console.error(error);
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
