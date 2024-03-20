import type { VercelRequest, VercelResponse } from "@vercel/node";

export default async function handler(req: VercelRequest, res: VercelResponse) {
  return res.send(`Hello! This is Ezlion's API 😎`);
}
