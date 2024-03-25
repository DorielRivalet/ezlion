import type { RequestHandler } from './$types';
import data from '../data.json';
import { respond } from '$lib/api';

export const GET: RequestHandler = ({ url, request, params }) => {
	const { id } = params;

	return respond(request, url, data, id);
};
