import type { VercelRequest, VercelResponse } from "@vercel/node";
import { respondWithDefaultValue } from "../../handler";

export default (req: VercelRequest, res: VercelResponse) => {
  respondWithDefaultValue(req, res, "skills-style-rank", false);
};
