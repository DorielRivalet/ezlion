import type { VercelRequest, VercelResponse } from "@vercel/node";
import { respondWithDefaultValue } from "../../handler";

const defaultValue = {
  id: 0,
  name: "None",
};

export default (req: VercelRequest, res: VercelResponse) => {
  respondWithDefaultValue(req, res, "monsters", false);
};
