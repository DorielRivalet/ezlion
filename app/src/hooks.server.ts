import type { Handle } from '@sveltejs/kit';
import { RateLimiter } from 'sveltekit-rate-limiter/server';

const limiter = new RateLimiter({
	IP: [30, 'm'],
	IPUA: [30, 'm']
});

export const handle: Handle = async ({ event, resolve }) => {
	if (await limiter.isLimited(event)) {
		// Create a new Response object for the 429 response
		return new Response('Too Many Requests', { status: 429 });
	}

	// Resolve the request and return the response
	const response = await resolve(event);
	return response;
};
