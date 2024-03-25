<script lang="ts">
	import { onMount } from 'svelte';
	import { page } from '$app/stores';
	import './catppuccin.css';
	import image from '$lib/assets/ezlion.png';
	import { authorName, description, projectName, website } from '$lib/constants';

	const title = 'API Reference';
	const url = $page.url.toString();
	onMount(() => {
		const script = document.createElement('script');
		script.src = 'https://cdn.jsdelivr.net/npm/@scalar/api-reference';
		script.id = 'api-reference';
		script.dataset.url = `https://${$page.url.hostname}/openapi.json`;
		document.body.appendChild(script);

		const apiReference = document.getElementById('api-reference');
	});
</script>

<svelte:head>
	<link rel="canonical" href={url} />

	<!-- HTML Meta Tags -->
	<title>{title}</title>
	<meta name="title" content={title} />
	<meta name="description" content={description} />

	{#if authorName}
		<meta name="author" content={authorName} />
	{/if}

	<!-- Google / Search Engine Tags -->
	{#if image}
		<meta itemprop="name" content={title} />
		<meta itemprop="description" content={description} />
		<meta itemprop="image" content={image} />
	{/if}

	<!-- Facebook Meta Tags -->
	{#if image}
		<meta property="og:url" content={url} />
		<meta property="og:type" content="website" />
		<meta property="og:title" content={title} />
		<meta property="og:description" content={description} />
		<meta property="og:image" content={image} />
		<meta property="og:image:alt" content="Elzelion wearing sunglasses" />
		<meta property="og:site_name" content={projectName} />
	{/if}

	<!-- Discord-->
	<meta content="#89b4fa" data-react-helmet="true" name="theme-color" />

	<!-- Twitter Meta Tags -->
	{#if image}
		<meta name="twitter:card" content="summary_large_image" />
		{#if website}
			<meta property="twitter:domain" content={website} />
		{/if}
		<meta property="twitter:url" content={url} />
		<meta name="twitter:title" content={title} />
		<meta name="twitter:description" content={description} />
		<meta name="twitter:image" content={image} />
	{/if}
</svelte:head>

<div id="api-reference-container" />

<style lang="css">
</style>
