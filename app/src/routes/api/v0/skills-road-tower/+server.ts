import { respond } from '$lib/api';
import type { RequestHandler } from './$types';
import data from './data.json';

export const GET: RequestHandler = ({ url, request }) => {
	return respond(request, url, data);
};
